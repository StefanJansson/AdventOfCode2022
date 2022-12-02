using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleTableExt;

namespace Helpers
{
    public class Presentation
    {
        private static readonly List<string> ColumnNames = new() { "Puzzel", "Part One", "Part Two" };
        private static readonly Dictionary<int, TextAligntment> Alignments = new()
        {
            {1, TextAligntment.Right},
            {2, TextAligntment.Right}
        };

        public static void DisplayResult(int year, List<List<object>> summaries)
        {
            Console.WriteLine($"AdventOfCode {year}");
            Console.WriteLine("");

            var daysToShow = DateTime.Compare(DateTime.Now, new DateTime(year, 12, 24)) > 0 ? 24 : DateTime.Now.Day;

            ConsoleTableBuilder
                .From(summaries.Take(daysToShow).ToList())
                .WithColumn(ColumnNames)
                .WithFormat(ConsoleTableBuilderFormat.Minimal)
                .WithTextAlignment(Alignments)

                //.WithOptions(new ConsoleTableBuilderOption { DividerString = "" })
                .ExportAndWriteLine();
        }
    }
}
