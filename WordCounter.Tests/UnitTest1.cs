using System.Collections.Generic;
using Xunit;
using WordCounter;
using System.Diagnostics;

namespace WordCounter.Tests
{

    public class PenghitungKataTests
    {
        [Fact]
        public void HitungElemen_BerhasilMenghitungKataDenganBenar()
        {
            // Arrange
            string[] input = { "apel", "mangga", "apel", "jeruk" };

            // Act
            var hasil = PenghitungKata.HitungElemen(input);

            // Assert
            Assert.Equal(2, hasil["apel"]);
            Assert.Equal(1, hasil["mangga"]);
            Assert.Equal(1, hasil["jeruk"]);
        }

        [Fact]
        public void HitungElemen_InputKosong_MengembalikanDictionaryKosong()
        {
            // Arrange
            string[] input = { };

            // Act
            var hasil = PenghitungKata.HitungElemen(input);

            // Assert
            Assert.Empty(hasil);
        }

        [Fact]
        public void HitungElemen_InputNull_MelemparArgumentNullException()
        {
            // Arrange
            string[] input = null;

            // Act & Assert
            Assert.Throws<ArgumentNullException>(() => PenghitungKata.HitungElemen(input));
        }

        [Fact]
        public void HitungElemen_KataBedaKasus_IgnoredCase()
        {
            // Arrange
            string[] input = { "Apel", "APEL", "apel" };

            // Act
            var hasil = PenghitungKata.HitungElemen(input);

            // Assert
            Assert.Equal(3, hasil["apel"]); // Pastikan key menggunakan huruf kecil
        }
    }
}