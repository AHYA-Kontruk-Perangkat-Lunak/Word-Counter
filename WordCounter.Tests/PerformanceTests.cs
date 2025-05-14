using System;
using System.Diagnostics;
using Xunit;
using WordCounter;

namespace WordCounter.Tests
{
    public class PerformanceTests
    {
        [Fact]
        public void HitungElemen_PerformanceTest_UntukDatasetBesar()
        {
            // Arrange: Buat dataset besar
            int ukuranDataset = 10_000_000;
            string[] dataset = GenerateTestData(ukuranDataset);

            var stopwatch = new Stopwatch();

            // Act
            stopwatch.Start();
            var hasil = PenghitungKata.HitungElemen(dataset);
            stopwatch.Stop();

            // Output hasil waktu eksekusi
            Console.WriteLine($"Waktu eksekusi untuk {ukuranDataset} kata: {stopwatch.ElapsedMilliseconds} ms");
            Console.WriteLine($"Jumlah kata unik: {hasil.Count}");
            Console.WriteLine($"Total kata: {dataset.Length}");

            // Assert: Batasi waktu eksekusi maksimal 1 detik
            Assert.True(stopwatch.ElapsedMilliseconds < 1000,
                $"Proses melebihi batas waktu (1000 ms): {stopwatch.ElapsedMilliseconds} ms");
        }
    }
}