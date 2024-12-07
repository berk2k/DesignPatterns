﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Singleton
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Logger logger1 = Logger.Instance;
            Logger logger2 = Logger.Instance;

            logger1.Log("First log message");
            logger2.Log("Second log message");

            
            Console.WriteLine(object.ReferenceEquals(logger1, logger2));
        }
    }
}
