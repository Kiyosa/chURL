using Microsoft.Extensions.Logging;
using CommandLine;
using Microsoft.Extensions.Options;
using static chURL.Program;
using Microsoft.Extensions.Logging.Console;

namespace chURL
{
    internal class Program
    {
        public class ProgramProps
        {
            private readonly ILogger logger;

            public ProgramProps(ILogger aLogger)
            {
                logger = aLogger;
            }

            public ILogger Logger { get => logger;  }
        }

        public class Options
        {
            private string? logFile;
            private bool logFileAppend;
            private LogLevel logLevel;

            [Option('o', "logFile", Default = null, Required = false, HelpText = "Log file output.")]
            public string? LogFile { get => logFile; set => logFile = value; }

            [Option('a', "logFileAppend", Default = true, Required = false, HelpText = "Append Log file output.")]
            public bool LogFileAppend { get => logFileAppend; set => logFileAppend = value; }

            [Option('l', "logLevel", Default = Microsoft.Extensions.Logging.LogLevel.Critical, Required = false, HelpText = "Logging level.")]
            public LogLevel LogLevel { get => logLevel; set => logLevel = value; }
        }

        static int Main(string[] args)
        {
            Parser.Default.ParseArguments<Options>(args)
                .WithParsed<Options>(options =>
                {
                    if (options.LogFileAppend)
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
            // Output some text on the console
            pp.Logger.LogInformation("Hello World!");
            pp.Logger.LogInformation("Logs contain timestamp and log level.");
            pp.Logger.LogInformation("Each log message is fit in a single line.");

            pp.Logger.LogInformation("Info Log");
            pp.Logger.LogWarning("Warning Log");
            pp.Logger.LogError("Error Log");
            pp.Logger.LogCritical("Critical Log");
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
                    StreamWriter streamWriter = new(options.LogFile, append: options.LogFileAppend);

                    // Add a custom log provider to write logs to text files
                    builder.AddProvider(new CustomFileLoggerProvider(streamWriter, options.LogLevel));
                }
            });

            // Create an ILogger
            return new ProgramProps(loggerFactory.CreateLogger<Program>());
        }

    }
}
