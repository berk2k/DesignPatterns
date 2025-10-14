namespace DesignPatterns.Singleton
{
    public class LoggerV2
    {
        private static LoggerV2 _instance;
        private static readonly object _lock = new object();

        private LoggerV2() {}

        public static LoggerV2 Instance
        {
            get
            {
                if( _instance == null)
                {
                    lock (_lock)
                    {
                        if (_instance == null)
                            _instance = new LoggerV2();
                    }
                }
                return _instance;
            }
        }
    }
}
