﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace SingletonTest
{
    public class Singleton
    {
        private static Singleton _instance;
        private static readonly object _lock = new object();

        private Singleton() { }

        public static Singleton Instance
        {
            get
            {
                lock (_lock)
                {
                    if (_instance == null)
                    {
                        _instance = new Singleton();
                    }
                    return _instance;
                }
            }
        }
        public void DoSomething()
        {
            Console.WriteLine("Singleton instance is working!!");
        }
    }
}
