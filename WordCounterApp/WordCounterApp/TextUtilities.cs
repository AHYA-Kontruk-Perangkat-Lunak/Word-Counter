using System;
using System.Collections.Generic;

public static class TextUtilities
{
    public static Dictionary<string, int> GetWordFrequency(string input, int minWordLength = 1)
    {
        if (string.IsNullOrEmpty(input)) throw new ArgumentException("Input tidak boleh kosong");

        var wordFrequency = new Dictionary<string, int>();
        var words = input.Split(new[] { ' ', '\n', '\r', '\t', '.', ',', ';', '!', '?' }, StringSplitOptions.RemoveEmptyEntries);

        foreach (var word in words)
        {
            var cleanedWord = word.ToLower().Trim();

            if (cleanedWord.Length >= minWordLength)
            {
                if (wordFrequency.ContainsKey(cleanedWord))
                {
                    wordFrequency[cleanedWord]++;
                }
                else
                {
                    wordFrequency[cleanedWord] = 1;
                }
            }
        }

        return wordFrequency;
    }
}
