using System;
using System.Collections.Generic;
using WordCounter;

namespace WordCounter
{
    public class Program
    {
        static void Main(string[] args)
        {
            bool exit = false;

            var menuActions = new Dictionary<string, Action>
            {
                { "1", PenghitungKata.TampilkanJumlahKata }
            };

            while (!exit)
            {
                Console.Clear();
                Console.WriteLine("===================================");
                Console.WriteLine("   Selamat Datang di Word Counter  ");
                Console.WriteLine("===================================");
                Console.WriteLine("Silakan pilih fitur yang ingin digunakan:");
                Console.WriteLine("1. Hitung Jumlah Kata");
                Console.WriteLine("0. Keluar");
                Console.Write("Masukkan pilihan Anda (0-5): ");

                string input = Console.ReadLine() ?? "";

                if (input == "0")
                {
                    exit = true;
                    Console.WriteLine("Terima kasih telah menggunakan aplikasi WordCounter.");
                }
                else if (menuActions.ContainsKey(input))
                {
                    menuActions[input].Invoke();
                }
                else
                {
                    Console.WriteLine("Pilihan tidak valid. Silakan coba lagi.");
                }

                if (!exit)
                {
                    Console.WriteLine("\nTekan ENTER ....");
                    Console.ReadKey();
                }
            }
        }
    }
}