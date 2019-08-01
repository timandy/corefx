using System.Collections.Generic;
using System.LinqCore;
using BenchmarkDotNet.Attributes;

namespace linqperf
{
    [MemoryDiagnoser]
    public class ReverseListPerf
    {
        private IEnumerable<int> data;

        [Params(10, 100, 1000)]
        public int COUNT;

        [GlobalSetup]
        public void Setup()
        {
            int[] tmp = new int[COUNT];
            for (int i = 0; i < COUNT; i++)
            {
                tmp[i] = i;
            }

            data = new List<int>(tmp);
        }

        [Benchmark]
        public int Reverse()
        {
            int sum = 0;
            foreach (int item in data.Reverse())
                sum += item;
            return sum;
        }

        [Benchmark(Baseline = true)]
        public int ReverseOld()
        {
            int sum = 0;
            foreach (int item in data.ReverseOld())
                sum += item;
            return sum;
        }
    }
}
