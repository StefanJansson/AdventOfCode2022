using System.Text.RegularExpressions;

namespace Aok2022.Puzzles;

internal class Day01
{
    public static List<object> Answer()
    {
        var puzzelInfo = Helpers.Puzzels.GetPuzzleInfo();
        if (!puzzelInfo.FileExists)
            return new List<object>() { puzzelInfo.PuzzleName };

        var fileData = File.ReadAllText(puzzelInfo.FileName);
        var splitFileData = fileData.Split("\n\n");
        var summaries = splitFileData
            .Select(_ => Regex.Matches(_, @"\d+")
                .Select(match => Convert.ToInt64(match.Value)).Sum())
            .OrderByDescending(_ => _)
            .ToList();
        return new List<object>() { puzzelInfo.PuzzleName, summaries.First(), summaries.Take(3).Sum() };
    }

}