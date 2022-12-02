// See https://aka.ms/new-console-template for more information

using Aok2022.Puzzles;
using ConsoleTableExt;

var columnNames = new List<string>() { "Puzzel", "Part One", "Part Two" };
var alignments = new Dictionary<int, TextAligntment>
{
    {1, TextAligntment.Right},
    {2, TextAligntment.Right}
};

Console.WriteLine("AdventOfCode 2022 | Stefan");
Console.WriteLine("");

var summaries = new List<List<object>>()
{
    Day01.Answer(), Day02.Answer(), Day03.Answer(), Day04.Answer(),
    Day05.Answer(), Day06.Answer(), Day07.Answer(), Day08.Answer(),
    Day09.Answer(), Day10.Answer(), Day11.Answer(), Day12.Answer(),
    Day13.Answer(), Day14.Answer(), Day15.Answer(), Day16.Answer(),
    Day17.Answer(), Day18.Answer(), Day19.Answer(), Day20.Answer(),
    Day21.Answer(), Day22.Answer(), Day23.Answer(), Day24.Answer()
};

var daysToShow = DateTime.Compare(DateTime.Now.Date, DateTime.Parse("2022-12-24").Date) > 0 ? 24 : DateTime.Now.Day;

ConsoleTableBuilder
    .From(summaries.Take(daysToShow).ToList())
    .WithColumn(columnNames)
    .WithFormat(ConsoleTableBuilderFormat.Minimal)
    .WithTextAlignment(alignments)

    //.WithOptions(new ConsoleTableBuilderOption { DividerString = "" })
    .ExportAndWriteLine();
