// See https://aka.ms/new-console-template for more information

using AokSJ;
using ConsoleTableExt;

Console.WriteLine("AdventOfCode!");
Console.WriteLine("");

var columnNames = new List<string>() { "Date", "Part One", "Part Two" };
var summaries = new List<List<object>>() { DailyQuiz.Day01()};
var alignments = new Dictionary<int, TextAligntment>
{
    {1, TextAligntment.Right},
    {2, TextAligntment.Right}
};
ConsoleTableBuilder
    .From(summaries)
    .WithColumn(columnNames)
    .WithFormat(ConsoleTableBuilderFormat.Minimal)
    .WithTextAlignment(alignments)

    //.WithOptions(new ConsoleTableBuilderOption { DividerString = "" })
    .ExportAndWriteLine();
