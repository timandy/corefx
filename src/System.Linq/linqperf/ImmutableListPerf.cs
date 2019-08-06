using System.Collections.Immutable;
using BenchmarkDotNet.Attributes;

namespace linqperf
{
    [CoreJob]
    [MemoryDiagnoser]
    public class ImmutableTest
    {
        private ImmutableList<int> data;

        [Params(10, 100, 1000, 10000, 100000)]
        public int length;

        [GlobalSetup]
        public void Init()
        {
            int[] items = new int[length];
            for (int i = 0; i < length; i++)
                items[i] = i;
            data = ImmutableList.Create(items);
        }

        [Benchmark(Baseline = true)]
        public int Enumerate()
        {
            int sum = 0;
            foreach (int item in data)
                sum += item;
            return sum;
        }

        [Benchmark]
        public int Index()
        {
            int sum = 0;
            ImmutableList<int> items = data;
            int len = items.Count;
            for (int i = 0; i < len; i++)
                sum += items[i];
            return sum;
        }
    }
}
