using System;
using System.Collections.Generic;

namespace SimpleWordCounter
{
    public static class WordCounter
    {
        // Menggunakan generics agar bisa menghitung frekuensi elemen dengan tipe apapun yang implementasikan IEquatable
        public static Dictionary<T, int> CountItems<T>(IEnumerable<T> items)
        {
            var counts = new Dictionary<T, int>();

            foreach (var item in items)
            {
                if (counts.ContainsKey(item))
                {
                    counts[item]++;
                }
                else
                {
                    counts[item] = 1;
                }
            }

            return counts;
        }

        // Fungsi ini sekarang menerima teks dan menghitung frekuensi setiap kata menggunakan generics
        public static void ShowWordCount()
        {
            Console.Clear();
            Console.WriteLine("=== Hitung Jumlah Kata ===");
            Console.Write("Masukkan teks: ");
            string textToCount = Console.ReadLine() ?? "";

            // Memecah teks menjadi kata-kata dan menghitung frekuensinya
            var words = textToCount.Split(new char[] { ' ', '\t', '\n', '\r' }, StringSplitOptions.RemoveEmptyEntries);

            // Menggunakan metode CountItems yang generik
            var wordCounts = CountItems(words);

            Console.WriteLine("\nJumlah Kata:");
            foreach (var kvp in wordCounts)
            {
                Console.WriteLine($"{kvp.Key}: {kvp.Value}");
            }
        }
    }
}