﻿namespace SingletonTest

{
    public class Program
    {
        static void Main(string[] args)
        {
            Singleton singleton1 = Singleton.Instance;
            Singleton singleton2 = Singleton.Instance;

            Console.WriteLine(singleton1 == singleton2);

            singleton1.DoSomething();
        }
    }
}
