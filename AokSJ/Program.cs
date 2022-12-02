// See https://aka.ms/new-console-template for more information

using AokSJ;
using ConsoleTableExt;

var columnNames = new List<string>() { "Date", "Part One", "Part Two" };
var alignments = new Dictionary<int, TextAligntment>
{
    {1, TextAligntment.Right},
    {2, TextAligntment.Right}
};

Console.WriteLine("AdventOfCode 2022 | Stefan!");
Console.WriteLine("");


var summaries = new List<List<object>>()
{
    DailyQuiz.Day01(), DailyQuiz.Day02(), DailyQuiz.Day03(), DailyQuiz.Day04(),
    DailyQuiz.Day05(), DailyQuiz.Day06(), DailyQuiz.Day07(), DailyQuiz.Day08(),
    DailyQuiz.Day09(), DailyQuiz.Day10(), DailyQuiz.Day11(), DailyQuiz.Day12(),
    DailyQuiz.Day13(), DailyQuiz.Day14(), DailyQuiz.Day15(), DailyQuiz.Day16(),
    DailyQuiz.Day17(), DailyQuiz.Day18(), DailyQuiz.Day19(), DailyQuiz.Day20(),
    DailyQuiz.Day21(), DailyQuiz.Day22(), DailyQuiz.Day23(), DailyQuiz.Day24()
};

var daysToShow = DateTime.Compare(DateTime.Now.Date, DateTime.Parse("2022-12-24").Date) > 0 ? 24 : DateTime.Now.Day;

ConsoleTableBuilder
    .From(summaries.Take(daysToShow).ToList())
    .WithColumn(columnNames)
    .WithFormat(ConsoleTableBuilderFormat.Minimal)
    .WithTextAlignment(alignments)

    //.WithOptions(new ConsoleTableBuilderOption { DividerString = "" })
    .ExportAndWriteLine();
