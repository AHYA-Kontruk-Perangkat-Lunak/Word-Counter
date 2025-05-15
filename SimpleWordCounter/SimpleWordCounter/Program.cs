using SimpleWordCounter.Features;


class Program
{
    static void Main()
    {
        Console.WriteLine("Masukkan teks:");
        string input = Console.ReadLine();

        Console.WriteLine("\n=== Hasil Analisis ===");
        Console.WriteLine($"Rata-rata panjang kata: {RataKata.Calculate(input):F2}");
        Console.WriteLine($"Jumlah kalimat: {JumlahKalimat.CountSentences(input)}");

        Console.WriteLine("\nTekan ENTER untuk keluar...");
        while (Console.ReadKey().Key != ConsoleKey.Enter)
        
            {

            } 


    }
}