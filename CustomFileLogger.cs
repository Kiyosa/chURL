using Microsoft.Extensions.Logging;

namespace chURL
{
    // Customized ILoggerProvider, writes logs to text files
    public class CustomFileLoggerProvider : ILoggerProvider
    {
        private readonly StreamWriter _logFileWriter;
        private readonly LogLevel _logLevel;

        public CustomFileLoggerProvider(StreamWriter logFileWriter, LogLevel logLevel)
        {
            _logFileWriter = logFileWriter ?? throw new ArgumentNullException(nameof(logFileWriter));
            _logLevel = logLevel;
        }

        public ILogger CreateLogger(string categoryName)
        {
            return new CustomFileLogger(categoryName, _logFileWriter, _logLevel);
        }

        public void Dispose()
        {
            _logFileWriter.Dispose();
        }
    }

    // Customized ILogger, writes logs to text files
    public class CustomFileLogger : ILogger
    {
        private readonly string _categoryName;
        private readonly StreamWriter _logFileWriter;
        private readonly LogLevel _logLevel;

        public CustomFileLogger(string categoryName, StreamWriter logFileWriter, LogLevel logLevel)
        {
            _categoryName = categoryName;
            _logFileWriter = logFileWriter;
            _logLevel = logLevel;
        }

        public IDisposable? BeginScope<TState>(TState state) where TState : notnull
        {
            //TODO: https://nblumhardt.com/2016/11/ilogger-beginscope/
            return null;
        }

        public bool IsEnabled(LogLevel logLevel)
        {
            // Ensure that only information level and higher logs are recorded
            return logLevel >= _logLevel;
        }

        public void Log<TState>(
            LogLevel logLevel,
            EventId eventId,
            TState state,
            Exception? exception,
            Func<TState, Exception?, string> formatter)
        {
            // Ensure that only information level and higher logs are recorded
            if (!IsEnabled(logLevel))
            {
                return;
            }

            // Get the formatted log message
            var message = formatter(state, exception);

            // Write log messages to text file
            string timeStamp = DateTime.Now.ToString("yyyy-MM-ddTHH:mm:ss");
            _logFileWriter.WriteLine($"{timeStamp} [{logLevel}] [{_categoryName}] {message}");
            _logFileWriter.Flush();
        }
    }

}
