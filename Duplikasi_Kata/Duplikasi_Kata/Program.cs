using System;
using System.Collections.Generic;
using System.Linq;

namespace DuplicateDetectorApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Masukkan kata:");
            string input = Console.ReadLine();

            IDuplicateDetector detector = new TableDrivenDuplicateDetector();
            var duplicates = detector.FindDuplicates(input);

            Console.WriteLine("Huruf duplikat: " + string.Join(", ", duplicates.Distinct()));
        }
    }

    // Interface (API reuse)
    public interface IDuplicateDetector
    {
        IEnumerable<char> FindDuplicates(string input);
    }

    // Teknik 1 Table-driven (dictionary)
    public class TableDrivenDuplicateDetector : IDuplicateDetector
    {
        public IEnumerable<char> FindDuplicates(string input)
        {
            var table = new Dictionary<char, int>();
            foreach (char c in input)
            {
                if (!char.IsLetter(c)) continue;
                char lower = char.ToLower(c);
                table[lower] = table.ContainsKey(lower) ? table[lower] + 1 : 1;
            }

            return table.Where(kvp => kvp.Value > 1).Select(kvp => kvp.Key);
        }
    }

    // Teknik 2 Automata-style state tracking
    public class StateBasedDuplicateDetector : IDuplicateDetector
    {
        public IEnumerable<char> FindDuplicates(string input)
        {
            HashSet<char> seen = new();
            HashSet<char> duplicates = new();

            foreach (char c in input.ToLower())
            {
                if (!char.IsLetter(c)) continue;
                if (!seen.Add(c)) duplicates.Add(c);
            }

            return duplicates;
        }
    }
}
