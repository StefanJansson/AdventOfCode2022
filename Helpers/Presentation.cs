using System;
using System.Collections.Generic;
using System.Diagnostics;
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
            var methodName = new StackFrame(1, false).GetMethod()!.DeclaringType!;
            Console.WriteLine($"AdventOfCode {year}");
            Console.WriteLine("");
            summaries.RemoveAll(_ => _.Count == 1);

            ConsoleTableBuilder
                .From(summaries)
                .WithColumn(ColumnNames)
                .WithFormat(ConsoleTableBuilderFormat.Minimal)
                .WithTextAlignment(Alignments)

                //.WithOptions(new ConsoleTableBuilderOption { DividerString = "" })
                .ExportAndWriteLine();
        }
    }
}
