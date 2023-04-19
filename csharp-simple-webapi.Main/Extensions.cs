﻿namespace csharp_simple_webapi.Main
{
   
        public static class EnumerableExtensions
    {
            public static IEnumerable<T> Times<T>(this int count, Func<int, T> func)
            {
                for (var i = 1; i <= count; i++) yield return func.Invoke(i);
            }
        }
    }

