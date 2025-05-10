using System;
using System.Collections.Generic;
using System.Linq;

namespace SimpleWordCounter.Features
{
    public class RataKata
    {
        
        private static double Average<T>(IEnumerable<T> items, Func<T, int> selector)
        {
            if (!items.Any()) return 0;
            return items.Select(selector).Average();
        }

        public static double Calculate(string text)
        {
            var words = text.Split(new[] { ' ', '\t', '\n', '\r' }, StringSplitOptions.RemoveEmptyEntries);
            return Average(words, w => w.Length);
        }
    }
}
