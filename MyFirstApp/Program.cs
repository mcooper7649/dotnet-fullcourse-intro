﻿using System;

namespace HelloWorld


{
    class Program
    {


        static void Main(string[] args)
        {
            WriteSomething();
            WriteSomethingSpecific("Hello Michael");
            Console.Read();

        }

        //access modifier (static) return type method name (parameter1, parameter2)

        public static void WriteSomething()
        {
            Console.WriteLine("I am called from a method");
        }

        public static void WriteSomethingSpecific(string myText)
        {
            Console.WriteLine(myText);
        }
    }
}

