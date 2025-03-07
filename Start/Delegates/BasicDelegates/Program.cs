﻿using System;

namespace BasicDelegates
{
    // TODO: declare the delegate type
    public delegate string MyDelegate(int arg1, int arg2);

    class MyClass
    {
        // Delegates can be bound to instance members as well as
        // static class functions
        public string instanceMethod1(int arg1, int arg2)
        {
            return ((arg1 + arg2) * arg1).ToString();
        }
    }

    class Program
    {
        // TODO: Create functions to serve as delegate implementations
        static string Func1(int a, int b)
        {
            return (a + b).ToString();
        }

        static string Func2(int a, int b)
        {
            return (a * b).ToString();
        }

        static void Main(string[] args)
        {
            // TODO: exercise each delegate function
            MyDelegate f = Func1;
            Console.WriteLine("The number from func1 is:" + f(10, 20));
            f = Func2;
            Console.WriteLine("The number from func2 is:" + f(10, 20));

            // TODO: Use an instance function of a class as a delegate

            var myClass = new MyClass();
            f = myClass.instanceMethod1;
            Console.WriteLine("The number from instanceMethod is:" + f(10, 20));

        }
    }
}
