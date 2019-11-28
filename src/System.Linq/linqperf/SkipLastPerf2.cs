using System.Collections.Generic;
using System.LinqCore;
using BenchmarkDotNet.Attributes;

namespace linqperf
{
    [MemoryDiagnoser]
    public class SkipLastPerf2
    {
        private IEnumerable<int> data;

        [Params(10, 100, 1000)]
        public int COUNT;

        [GlobalSetup]
        public void Setup()
        {
            data = GetInput(COUNT);
        }

        private static IEnumerable<int> GetInput(int count)
        {
            for (int i = 0; i < count; i++) yield return i;
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
