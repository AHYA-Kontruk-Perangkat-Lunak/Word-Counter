using System;
using System.Collections.Generic;

namespace SimpleWordCounter
{
    public static class FrequencyCounter
    {
        private static readonly HashSet<string> StopWords = new HashSet<string>
        {
            "dan", "di", "ke", "dari", "yang", "ini"
        };

        public static Dictionary<T, int> CountFrequency<T>(List<T> items)
        {
            var frequency = new Dictionary<T, int>();

            foreach (var item in items)
            {
                if (frequency.ContainsKey(item))
                {
                    frequency[item]++;
                }
                else
                {
                    frequency[item] = 1;
                }
            }

            return frequency;
        }

        public static void ShowWordFrequencies(string text)
        {
            Console.Clear();
            Console.WriteLine("=== Frekuensi Kemunculan Kata ===");

            if (string.IsNullOrWhiteSpace(text))
            {
                Console.WriteLine("Teks kosong!");
                return;
            }

            string[] words = text.Split(' ', StringSplitOptions.RemoveEmptyEntries);

            List<string> filteredWords = new List<string>();
            foreach (var word in words)
            {
                if (!StopWords.Contains(word.ToLower()))
                {
                    filteredWords.Add(word.ToLower());
                }
            }

            var frequency = CountFrequency(filteredWords);

            Console.WriteLine("\nFrekuensi Kata:");
            foreach (var pair in frequency)
            {
                Console.WriteLine($"{pair.Key}: {pair.Value} kali");
            }
        }
    }
}