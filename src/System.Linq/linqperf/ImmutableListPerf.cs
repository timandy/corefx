using System.Collections.Generic;
using System.Collections.Immutable;
using BenchmarkDotNet.Attributes;

namespace linqperf
{
    [CoreJob]
    public class ImmutableTest
    {
        private ImmutableList<int> data;

        [Params(10, 100, 1000)]
        public int length;

        [GlobalSetup]
        public void Init()
        {
            int[] a = new int[length];
            for (int i = 0; i < length; i++)
            {
                a[i] = i;
            }

            data = ImmutableList.Create(a);
        }

        [Benchmark]
        public int Enumerate()
        {
            int sum = 0;
            using (IEnumerator<int> e = data.GetEnumerator())
            {
                while (e.MoveNext())
                    sum += e.Current;
            }

            return sum;
        }

        [Benchmark]
        public int Index()
        {
            int sum = 0;
            ImmutableList<int> dataTmp = data;
            for (int i = 0, len = length; i < len; i++)
                sum += dataTmp[i];
            return sum;
        }
    }
}
