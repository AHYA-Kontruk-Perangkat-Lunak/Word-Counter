using System.Collections.Generic;
using Xunit;
using WordCounter;
using System.Diagnostics;

public class PenghitungKataTests
{
    // === UNIT TEST ===
    [Fact]
    public void HitungElemen_InputKosong_MengembalikanDictionaryKosong()
    {
        var input = new List<string>();
        var hasil = PenghitungKata.HitungElemen(input);

        Assert.Empty(hasil);
    }

    [Fact]
    public void HitungElemen_SatuKata_MengembalikanHitungSatu()
    {
        var input = new List<string> { "hello" };
        var hasil = PenghitungKata.HitungElemen(input);

        Assert.Single(hasil);
        Assert.Equal(1, hasil["hello"]);
    }

    [Fact]
    public void HitungElemen_DuaKataSama_MengembalikanHitungDua()
    {
        var input = new List<string> { "hello", "hello" };
        var hasil = PenghitungKata.HitungElemen(input);

        Assert.Single(hasil);
        Assert.Equal(2, hasil["hello"]);
    }

    [Fact]
    public void HitungElemen_BeragamKata_MengembalikanHitungYangBenar()
    {
        var input = new List<string> { "hello", "world", "hello" };
        var hasil = PenghitungKata.HitungElemen(input);

        Assert.Equal(2, hasil["hello"]);
        Assert.Equal(1, hasil["world"]);
    }

    // === PERFORMANCE TEST ===
    [Fact]
    public void HitungElemen_PerformanceTest_DataBesar()
    {
        var input = new List<string>();
        for (int i = 0; i < 10000000; i++)
        {
            input.Add("kata" + (i % 100));
        }

        var stopwatch = Stopwatch.StartNew();
        var hasil = PenghitungKata.HitungElemen(input);
        stopwatch.Stop();

        // Target: harus selesai di bawah 1000 ms (1 detik)
        Assert.True(stopwatch.ElapsedMilliseconds < 1000, $"Terlalu lambat: {stopwatch.ElapsedMilliseconds} ms");
    }
}