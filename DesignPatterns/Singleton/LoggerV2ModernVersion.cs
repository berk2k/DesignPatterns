namespace DesignPatterns.Singleton
{
    public sealed class LoggerV2ModernVersion
    {
        private static readonly Lazy<LoggerV2ModernVersion> _instance =
            new Lazy<LoggerV2ModernVersion>(() => new LoggerV2ModernVersion());
              
        private LoggerV2ModernVersion() { }

        private static LoggerV2ModernVersion Instance => _instance.Value;
    }
}
