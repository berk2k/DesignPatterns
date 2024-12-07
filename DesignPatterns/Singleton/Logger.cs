using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Singleton
{
    public class Logger
    {
        private static Logger _instance;

        private Logger() { }

        public static Logger Instance
        {
            get
            {
                if(_instance == null)
                {
                    _instance = new Logger();
                }

                return _instance;
            }
        }

        public void Log(string message)
        {
            Console.WriteLine($"Log: {message}");
        }

    }
}
