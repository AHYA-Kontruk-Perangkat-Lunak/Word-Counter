using System;
using System.Collections.Generic;

namespace WordCounter
{
    public static class PenghitungKata
    {
        public static Dictionary<T, int> HitungElemen<T>(IEnumerable<T> elemen) where T : notnull
        {
            var hitungan = new Dictionary<T, int>();

            foreach (var elemenItem in elemen)
            {
                if (hitungan.ContainsKey(elemenItem))
                {
                    hitungan[elemenItem]++;
                }
                else
                {
                    hitungan[elemenItem] = 1;
                }
            }

            return hitungan;
        }

        public static void TampilkanJumlahKata()
        {
            Console.Clear();
            Console.WriteLine("=== Hitung Jumlah Kata ===");
            Console.Write("Masukkan teks: ");
            string teksUntukDihitung = Console.ReadLine() ?? "";

            var kataKata = teksUntukDihitung.Split(new char[] { ' ', '\t', '\n', '\r' }, StringSplitOptions.RemoveEmptyEntries);

            var hitunganKata = HitungElemen(kataKata);

            Console.WriteLine("\nJumlah Kata per Kata:");
            foreach (var kvp in hitunganKata)
            {
                Console.WriteLine($"{kvp.Key}: {kvp.Value}");
            }

            int totalKata = 0;
            foreach (var jumlah in hitunganKata.Values)
            {
                totalKata += jumlah;
            }

            Console.WriteLine($"\nTotal semua kata: {totalKata}");
        }
    }
}