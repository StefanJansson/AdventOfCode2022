using System.Text.RegularExpressions;
using Helpers;

namespace Aok2022.Puzzles;

internal static class Day01
{
    public static List<object> Answer()
    {
        var puzzleInfo = Helpers.Puzzles.GetPuzzleInfo();
        if (!puzzleInfo.FileExists)
            return new List<object>() { puzzleInfo.Name };

        var fileData = puzzleInfo.GetInputAsText();
        var splitFileData = fileData.Split("\n\n");

        // Part One & Two 
        var summaries = splitFileData
            .Select(_ => Regex.Matches(_, @"\d+")
                .Select(match => Convert.ToInt64(match.Value)).Sum())
            .OrderByDescending(_ => _)
            .ToList();
        return new List<object>() { puzzleInfo.Name, summaries.First(), summaries.Take(3).Sum() };
    }

}