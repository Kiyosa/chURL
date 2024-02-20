using Microsoft.Extensions.Logging;
using CommandLine;
using static chURL.Program;


namespace chURL
{
    internal class Program
    {
        public enum AuthType
        {
            None,
            Basic,
            ApiKey,
            OAuth2,
            NTLM
        };

        public class Options
        {
            private bool test;
            private string? logFile;
            private bool logFileAppend;
            private LogLevel logLevel;
            private int timeOutMillisec;
            private AuthType authType;
            private string authUser;
            private string authPassword;
            private string apiKey;
            private string acceptHeader;
            private string method;
            private string url;

            public Options()
            {
                authType = AuthType.None;
                authUser = Environment.GetEnvironmentVariable("AuthUser") ?? string.Empty;
                authPassword = Environment.GetEnvironmentVariable("AuthPassword") ?? string.Empty;
                apiKey = Environment.GetEnvironmentVariable("ApiKey") ?? string.Empty;
                acceptHeader = string.Empty;
                method = string.Empty;
                url = string.Empty;
            }

            [Option('e', "test", Default = false, Required = false, HelpText = "Execute tests")]
            public bool Test { get => test; set => test = value; }

            [Option('a', "accept", Default = "application/json", Required = false, HelpText = "Accept content type header.")]
            public string Accept { get => acceptHeader; set => acceptHeader = value; }

            [Option('o', "logFile", Default = "chURL.log", Required = false, HelpText = "Log file output.")]
            public string? LogFile { get => logFile; set => logFile = value; }

            [Option('c', "clear", Default = false, Required = false, HelpText = "Clear log file output.")]
            public bool ClearLogFile { get => logFileAppend; set => logFileAppend = value; }

            [Option('k', "apikey", Default = LogLevel.Error, Required = false, HelpText = "API Key.")]
            public string ApiKey { get => apiKey; set => apiKey = value; }

            [Option('l', "logLevel", Default = LogLevel.Error, Required = false, HelpText = "Logging level.")]
            public LogLevel LogLevel { get => logLevel; set => logLevel = value; }

            [Option('t', "timeOut", Default = 1000, Required = false, HelpText = "Request time out wait in milliseconds.")]
            public int TimeOut { get => timeOutMillisec; set => timeOutMillisec = value; }

            [Option('u', "User", Required = false, HelpText = "User name for Basic Authorization.")]
            public string AuthUser { get => authUser; set => authUser = value; }

            [Option('p', "Password", Required = false, HelpText = "Password for Basic Authorization.")]
            public string AuthPassword { get => authPassword; set => authPassword = value; }

            [Option('z', "authorizationType", Default = AuthType.Basic, Required = false, HelpText = "Authorization { Basic, ApiKey, OAuth2, NTLM }.")]
            public AuthType Authorization { get => authType; set => authType = value; }

            [Option('m', "method", Default = "GET", Required = false, HelpText = "HTTP Method to use { HEAD, GET, POST, PUT, DELETE }")]
            public string Method { get => method; set => method = value; }

            [Value(0, MetaName = "URL", Required = true, HelpText = "API URL e.g. https://domain.example/endpoint?arg1=x&arg2=y")]
            public string URL { get => url; set => url = value; }
        }

        public class Properties(Options theOptions, ILoggerFactory theLoggerFactory)
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
            return ParseArgsAndRun(args);
        }

        private static int ParseArgsAndRun(string[] args)
        {
            Parser.Default.ParseArguments<Options>(args)
                .WithParsed<Options>(options =>
                {
                    if (options.ClearLogFile && options.LogFile != null)
                    {
                        File.Delete(options.LogFile);
                        Console.Write("Cleared ");
                    }
                    Console.WriteLine($"Log file: -f {options.LogFile}");
                    Console.WriteLine($"Log level: -l {options.LogLevel}");

                    var httpRequestManager = new HttpRequestManager(ConfigureLogger(options));
                    httpRequestManager.Execute();

                }).WithNotParsed(HandleParseError);

            return 0;
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
                    // Add a custom log provider to write logs to text files
                    builder.AddProvider(
                        new CustomFileLoggerProvider(
                            new(options.LogFile, append: true), options.LogLevel));
                }
            });

            // Create an ILogger
            return new Properties(options, loggerFactory);
        }

    }
}
