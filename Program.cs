using System;
using System.Collections.Generic;

namespace SimpleWordCounter
{
    class Program
    {
        static void Main(string[] args)
        {
            bool exit = false;

            while (!exit)
            {
                Console.Clear();
                Console.WriteLine("===================================");
                Console.WriteLine("   Selamat Datang di Word Counter  ");
                Console.WriteLine("===================================");
                Console.WriteLine("Silakan pilih fitur yang ingin digunakan:");
                Console.WriteLine("1. Hitung Jumlah Kata");
                Console.WriteLine("2. Tampilkan Frekuensi Kata");
                Console.WriteLine("3. Hitung Jumlah Karakter");
                Console.WriteLine("4. Periksa Kata Terlarang");
                Console.WriteLine("5. Keluar");
                Console.Write("Masukkan pilihan Anda (1-5): ");

                string input = Console.ReadLine();

                switch (input)
                {
                    case "1":
                        WordCounter.CountWords();
                        break;
                    case "5":
                        exit = true;
                        Console.WriteLine("Terima kasih telah menggunakan aplikasi ini.");
                        break;
                    default:
                        Console.WriteLine("Pilihan tidak valid. Silakan coba lagi.");
                        break;
                }

                if (input != "5")
                {
                    Console.WriteLine("\nTekan sembarang tombol untuk kembali ke menu...");
                    Console.ReadKey();
                }
            }
        }
    }
}