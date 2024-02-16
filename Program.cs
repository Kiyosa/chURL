using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Logging.Configuration;
using Microsoft.Extensions.Logging.Console;

namespace chURL
{
    internal class Program
    {
        static int Main(string[] args)
        {
            if (args.Length == 0)
            {
                Console.WriteLine("Missing command line args. /? for usage.");
                return 1;
            }

            // Create a StreamWriter to write logs to a text file
            StreamWriter logFileWriter = new(args[0], append: false);

            ILogger logger = ConfigureLogger(logFileWriter);
            // Output some text on the console
            using (logger.BeginScope("[scope is enabled]"))
            {
                logger.LogInformation("Hello World!");
                logger.LogInformation("Logs contain timestamp and log level.");
                logger.LogInformation("Each log message is fit in a single line.");

                logger.LogInformation("Info Log");
                logger.LogWarning("Warning Log");
                logger.LogError("Error Log");
                logger.LogCritical("Critical Log");
            }

            return 0;
        }

        static ILogger ConfigureLogger(StreamWriter logFileWriter)
        {
            // Create an ILoggerFactory
            ILoggerFactory loggerFactory = LoggerFactory.Create(builder =>
            {
                //Add console output
                builder.AddSimpleConsole(options =>
                {
                    options.IncludeScopes = true;
                    options.SingleLine = true;
                    options.TimestampFormat = "yyyy-MM-dd HH:mm:ss ";
                });

                // Add a custom log provider to write logs to text files
                builder.AddProvider(new CustomFileLoggerProvider(logFileWriter));
            });

            // Create an ILogger
            ILogger<Program> logger = loggerFactory.CreateLogger<Program>();

            return logger;
        }

    }
}
