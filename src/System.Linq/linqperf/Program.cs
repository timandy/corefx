using System;
using System.Reflection;
using BenchmarkDotNet.Running;

namespace linqperf
{
    class Program
    {
        static void Main(string[] args)
        {
            BenchmarkSwitcher.FromAssembly(typeof(Program).GetTypeInfo().Assembly).Run(args);
            Console.ReadLine();
        }
    }
}
