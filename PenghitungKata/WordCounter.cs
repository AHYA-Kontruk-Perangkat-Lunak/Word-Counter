using System;
using System.Collections.Generic;

namespace WordCounter
{
    public static class PenghitungKata
    {
        public static Dictionary<T, int> HitungElemen<T>(IEnumerable<T> elemen) where T : notnull
        {
            if (elemen == null)
                throw new ArgumentNullException(nameof(elemen));

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
            try
            {
                Console.Clear();
                Console.WriteLine("=== Hitung Jumlah Kata ===");
                Console.Write("Masukkan teks: ");
                string teksUntukDihitung = Console.ReadLine() ?? "";

                var kataKata = teksUntukDihitung.Split(
                    new char[] { ' ', '\t', '\n', '\r' },
                    StringSplitOptions.RemoveEmptyEntries);

                var hitunganKata = HitungElemen(kataKata);

                Console.WriteLine("\nJumlah Kata per Kata:");
                foreach (var item in hitunganKata)
                {
                    Console.WriteLine($"{item.Key}: {item.Value}");
                }

                int totalKata = hitunganKata.Count > 0 ? hitunganKata.Values.Sum() : 0;

                Console.WriteLine($"\nTotal semua kata: {totalKata}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Terjadi kesalahan: {ex.Message}");
            }
        }
    }
}