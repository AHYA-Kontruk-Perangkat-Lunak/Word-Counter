using System;
using System.Collections.Generic;

public class Duplikasi_Kata
{
    static void Main()
    {
        Console.ForegroundColor = ConsoleColor.Gray;
        Console.WriteLine("╔════════════════════════════════════════╗");
        Console.WriteLine("║          Deteksi Duplikat Kata         ║");
        Console.WriteLine("║            ( '/' untuk exit)           ║");
        Console.WriteLine("╚════════════════════════════════════════╝");
        Console.ResetColor();
        // alt 201 alt 205 
        while (true)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write("Text: ");
            Console.ResetColor();

            string input = Console.ReadLine()?.ToLower();

            if (string.IsNullOrEmpty(input))
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Input tidak valid, silakan coba lagi.");
                Console.ResetColor();
                continue;
            }

            var duplicates = TableDrivenDetector.CariDuplikat(input);;

            if (duplicates.Count == 0)
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("Tidak ada huruf yang berulang.");
                Console.ResetColor();
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine("Huruf yg berulang:");
                Console.ResetColor();

                Console.WriteLine("┌────────────┬──────────┐");
                Console.WriteLine("│   Huruf    │ Jumlah   │");
                Console.WriteLine("├────────────┼──────────┤");

                foreach (var pair in duplicates)
                {
                    Console.WriteLine($"│      {pair.Key}    │     {pair.Value}    │");
                }

                Console.WriteLine("└────────────┴──────────┘");
            }

            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.WriteLine("───────────────────────────────");
            Console.ResetColor();

            if (input == "/")
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("╔════════════════╗");
                Console.WriteLine("║  Terima kasih  ║");
                Console.WriteLine("╚════════════════╝");
                Console.ResetColor();
                break;
            }
        }
    }
}

static class TableDrivenDetector
{
    public static Dictionary<char, int> CariDuplikat(string input)
    {
        Dictionary<char, int> tabelHuruf = new Dictionary<char, int>();

        foreach (char huruf in input)
        {
            if (!char.IsLetter(huruf)) continue;

            if (tabelHuruf.ContainsKey(huruf))
                tabelHuruf[huruf]++;
            else
                tabelHuruf[huruf] = 1;
        }

        var hasil = new Dictionary<char, int>();
        foreach (var pair in tabelHuruf)
        {
            if (pair.Value > 1)
                hasil.Add(pair.Key, pair.Value);
        }

        return hasil;
    }
}

static class AutomataDetector
{
    public static Dictionary<char, int> CariDuplikat(string input)
    {
        HashSet<char> hurufTerlihat = new HashSet<char>();
        Dictionary<char, int> duplikat = new Dictionary<char, int>();

        foreach (char huruf in input)
        {
            if (!char.IsLetter(huruf)) continue;

            if (hurufTerlihat.Contains(huruf))
            {
                if (duplikat.ContainsKey(huruf))
                    duplikat[huruf]++;
                else
                    duplikat[huruf] = 2;
            }
            else
            {
                hurufTerlihat.Add(huruf);
            }
        }

        return duplikat;
    }
}