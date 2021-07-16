using BenchmarkDotNet.Running;
using System;

namespace DotnetUuid
{
    class Program
    {
        static void Main(string[] args)
        {
            BenchmarkRunner.Run<Benchmarks>();
        }
    }
}
