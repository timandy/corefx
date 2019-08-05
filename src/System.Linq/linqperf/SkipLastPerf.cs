using System.Collections.Generic;
using System.LinqCore;
using BenchmarkDotNet.Attributes;

namespace linqperf
{
    [MemoryDiagnoser]
    public class SkipLastPerf
    {
        private IEnumerable<int> data;

        [Params(10, 100, 1000)]
        public int COUNT;

        [GlobalSetup]
        public void Setup()
        {
            List<int> tmp = new List<int>(COUNT);
            for (int i = 0; i < COUNT; i++)
            {
                tmp.Add(i);
            }

            data = tmp;
        }

        [Benchmark]
        public int SkipLast()
        {
            return data.SkipLast(5).Sum();
        }

        [Benchmark(Baseline = true)]
        public int SkipLastOld()
        {
            return data.SkipLastOld(5).Sum();
        }
    }
}
