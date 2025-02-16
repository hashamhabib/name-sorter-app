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
