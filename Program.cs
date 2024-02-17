using Microsoft.Extensions.Logging;
using CommandLine;
using Microsoft.Extensions.Options;
using static chURL.Program;
using Microsoft.Extensions.Logging.Console;

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

            [Value(0, MetaName = "URL", Required = true, HelpText = "API URL e.g. https://domain.example/endpoint?arg1=x&arg2=y")]
            public string URL { get => url; set => url = value; }
        }

        public class ProgramProps(Program.Options theOptions, ILogger aLogger)
        {
            private readonly Options options = theOptions;
            private readonly ILogger logger = aLogger;

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

        static void RunWith(ProgramProps pp)
        {
            var api = new RestCall(pp.Logger);
            var task = api.Call(pp.Options.URL);
            task.Wait();

            bool returned = true;
            if (returned)
            {
                if (task.Result.Status != System.Net.HttpStatusCode.OK)
                {
                    pp.Logger.LogError($"HttpError: {task.Result.Status}");
                }
                else
                {
                    pp.Logger.LogDebug(task.Result.JSON);
                }
            }
            else
            {
                pp.Logger.LogError("Request timed out.");
            }
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

        private static ProgramProps ConfigureLogger(Options options)
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
            return new ProgramProps(options, loggerFactory.CreateLogger<Program>());
        }

    }
}
