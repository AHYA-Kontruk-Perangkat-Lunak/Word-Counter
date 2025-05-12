using System;
using System.Linq;  
using System.Collections.Generic;
using System.Diagnostics;  

class Program
{
    static void Main()
    {
        Console.WriteLine("Masukkan teks yang ingin dihitung frekuensi katanya:");

        string inputText = Console.ReadLine();

        if (string.IsNullOrEmpty(inputText))
        {
            Console.WriteLine("Teks tidak boleh kosong.");
            return; 
        }

        var stopwatch = Stopwatch.StartNew();

        var wordFrequency = TextUtilities.GetWordFrequency(inputText, 3);  

        stopwatch.Stop();

        Console.WriteLine($"\nWaktu eksekusi: {stopwatch.ElapsedMilliseconds} ms");

        var sortedWordFrequency = wordFrequency.OrderByDescending(kvp => kvp.Value);

        Console.WriteLine("\nKata yang Paling Sering Muncul:");
        foreach (var entry in sortedWordFrequency)
        {
            Console.WriteLine($"Kata: {entry.Key}, Frekuensi: {entry.Value}");
        }

        Console.ReadLine();
    }
}
