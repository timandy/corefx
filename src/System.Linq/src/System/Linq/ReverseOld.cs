using System.Collections.Generic;

namespace System.LinqCore
{
    public static partial class Enumerable
    {
        public static IEnumerable<TSource> ReverseOld<TSource>(this IEnumerable<TSource> source)
        {
            if (source == null)
            {
                ThrowHelper.ThrowArgumentNullException(ExceptionArgument.source);
            }

            return new ReverseEnumerableIterator<TSource>(source);
        }
    }
}
