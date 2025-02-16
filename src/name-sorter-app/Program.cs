using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace name_sorter_app
{
    class Program
    {
        static void Main(string[] args)
        {
            if (args.Length == 0)
            {
                Console.WriteLine("Usage: name-sorter <file-path>");
                return;
            }

            string inputFilePath = args[0];
            string outputFilePath = "sorted-names-list.txt";

            try
            {
                List<string> names = File.ReadAllLines(inputFilePath).ToList();

                // Validate names before sorting
                names = names.Where(ValidateName).ToList();

                List<string> sortedNames = NameSorter.SortNames(names);

                Console.WriteLine("\nSorted Names:");
                sortedNames.ForEach(Console.WriteLine);

                File.WriteAllLines(outputFilePath, sortedNames);
                Console.WriteLine($"\nSorted names saved to {outputFilePath}");

            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }
        }
        static bool ValidateName(string name)
        {
            var parts = name.Split(' ');
            if (parts.Length < 2 || parts.Length > 4)
            {
                Console.WriteLine($"Invalid name format: {name}. It must have at least 1 given name and up to 3 given names.");
                return false;
            }
            return true;
        }
    }

    public static class NameSorter
    {
        public static List<string> SortNames(List<string> names)
        {
            return names.OrderBy(n => GetLastName(n)).ThenBy(n => n).ToList();
        }

        private static string GetLastName(string name)
        {
            var parts = name.Split(' ');
            return parts.Last();
        }
    }
}
