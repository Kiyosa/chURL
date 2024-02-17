using Microsoft.Extensions.Logging;
using CommandLine;


namespace chURL
{
    internal class Program
    {
        public class Options
        {
            private string? logFile;
            private bool logFileAppend;
            private LogLevel logLevel;
            private string url;
            private int timeOutMillisec;

            public Options()
            {
                url = string.Empty;
            }            

            [Option('o', "logFile", Default = "chURL.log", Required = false, HelpText = "Log file output.")]
            public string? LogFile { get => logFile; set => logFile = value; }

            [Option('a', Default = false, Required = false, HelpText = "Append Log file output.")]
            public bool Append { get => logFileAppend; set => logFileAppend = value; }

            [Option('l', "logLevel", Default = LogLevel.Error, Required = false, HelpText = "Logging level.")]
            public LogLevel LogLevel { get => logLevel; set => logLevel = value; }

            [Option('t', "timeOut", Default = 1000, Required = false, HelpText = "Request time out wait in milliseconds.")]
            public int TimeOut {  get => timeOutMillisec; set => timeOutMillisec = value; }

            [Value(0, MetaName = "URL", Required = true, HelpText = "API URL e.g. https://domain.example/endpoint?arg1=x&arg2=y")]
            public string URL { get => url; set => url = value; }
        }

        public class Properties(Program.Options theOptions, ILoggerFactory theLoggerFactory)
        {
            private readonly Options options = theOptions;
            private readonly ILoggerFactory loggerFactory = theLoggerFactory;
            private readonly ILogger logger = theLoggerFactory.CreateLogger<Program>();

            public ILoggerFactory LoggerFactory { get => loggerFactory; }
            public ILogger Logger { get => logger; }
            public Options Options { get => options; }
        }


        static int Main(string[] args)
        {
            Parser.Default.ParseArguments<Options>(args)
                .WithParsed<Options>(options =>
                {
                    if (options.Append)
                    {
                        Console.Write("Appending to ");
                    }
                    else
                    {
                        Console.Write("Overwriting ");
                    }
                    Console.WriteLine($"Log file: -f {options.LogFile}");

                    Console.WriteLine($"Log level: -l {options.LogLevel}");

                    RunWith(ConfigureLogger(options));

                }).WithNotParsed(HandleParseError);

            return 0;
        }

        static void RunWith(Properties pp)
        {
            var api = new RestCall(pp);
            var task = api.Call(pp.Options.URL);
            var returned = task.Wait(pp.Options.TimeOut);
            if (!returned)
            {
                pp.Logger.LogError("API Call Request timed out.");
            }
            pp.Logger.LogInformation(task.Result.JSON);
        }

        private static void HandleParseError(IEnumerable<Error> errs)
        {
            if (errs.IsVersion())
            {
                Console.WriteLine("Version Request");
                return;
            }

            if (errs.IsHelp())
            {
                Console.WriteLine("Help Request");
                return;
            }

            Console.WriteLine("Parser Fail");
        }

        private static Properties ConfigureLogger(Options options)
        {
            // Create an ILoggerFactory
            ILoggerFactory loggerFactory = LoggerFactory.Create(builder =>
            {
                //Add console output
                builder.AddSimpleConsole(options =>
                {
                    options.IncludeScopes = false;
                    options.SingleLine = true;
                    options.UseUtcTimestamp = true;
                });

                builder.SetMinimumLevel(options.LogLevel);

                if (options.LogFile != null)
                {
                    // Create a StreamWriter to write logs to a text file
                    StreamWriter streamWriter = new(options.LogFile, append: options.Append);

                    // Add a custom log provider to write logs to text files
                    builder.AddProvider(new CustomFileLoggerProvider(streamWriter, options.LogLevel));
                }
            });

            // Create an ILogger
            return new Properties(options, loggerFactory);
        }

    }
}
