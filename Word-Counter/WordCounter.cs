using System;
using System.Collections.Generic;

namespace WordCounter
{
    public static class PenghitungKata
    {
        public static Dictionary<T, int> HitungElemen<T>(IEnumerable<T> elemen) where T : notnull
        {
            // Validasi input null
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
            Console.Clear();
            Console.WriteLine("=== Hitung Jumlah Kata ===");
            Console.Write("Masukkan teks: ");
            string teksUntukDihitung = Console.ReadLine() ?? "";

            // Defensive: Trim dan validasi input kosong
            teksUntukDihitung = teksUntukDihitung.Trim();
            if (string.IsNullOrEmpty(teksUntukDihitung))
            {
                Console.WriteLine("Teks tidak boleh kosong!");
                return;
            }

            var kataKata = teksUntukDihitung.Split(
                new char[] { ' ', '\t', '\n', '\r' },
                StringSplitOptions.RemoveEmptyEntries
            );

            var hitunganKata = HitungElemen(kataKata);

            // Tampilkan hasil
            Console.WriteLine("\nJumlah Kata per Kata:");
            foreach (var kvp in hitunganKata)
            {
                Console.WriteLine($"{kvp.Key}: {kvp.Value}");
            }

            int totalKata = hitunganKata.Values.Sum();
            Console.WriteLine($"\nTotal semua kata: {totalKata}");
        }
    }
}