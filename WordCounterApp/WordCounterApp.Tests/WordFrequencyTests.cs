
using Xunit;

public class WordFrequencyTests
{
    [Fact] 
    public void TestWordFrequencyWithSampleText()
    {
        var inputText = "Halo dunia, dunia itu indah.";

        var wordFrequency = TextUtilities.GetWordFrequency(inputText, 3);

        Assert.Equal(2, wordFrequency["dunia"]);

        Assert.Equal(1, wordFrequency["halo"]);

        Assert.Equal(1, wordFrequency["indah"]);
    }
}
