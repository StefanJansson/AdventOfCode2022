using System.Text.RegularExpressions;
using Helpers;

namespace Aok2022.Puzzles;

internal static class Day04
{
    public static List<object> Answer()
    {
        var puzzleInfo = Helpers.Puzzles.GetPuzzleInfo();
        if (!puzzleInfo.FileExists)
            return new List<object>() { puzzleInfo.Name };

        var allRanges = puzzleInfo.GetInputAsList();

        var fullOverlappingRanges = new List<string>();
        var partialOverlappingRanges = new List<string>();

        foreach (var ranges in allRanges)
        {
            var rangeValues = Regex.Matches(ranges, @"\d+").Select(_ => Convert.ToInt16(_.Value)).ToList();
            var range1 = Enumerable.Range(rangeValues[0], 1 + rangeValues[1] - rangeValues[0]).ToList();
            var range2 = Enumerable.Range(rangeValues[2], 1 + rangeValues[3] - rangeValues[2]).ToList();

            var y1 = range1.Except(range2).ToList();
            var y2 = range2.Except(range1).ToList();

            // Part One
            if (!range1.Except(range2).Any() || !range2.Except(range1).Any())
                fullOverlappingRanges.Add(ranges);

            // Part Two
            if (range1.Intersect(range2).Any())
                partialOverlappingRanges.Add(ranges);
        }
        
        return new List<object>() { puzzleInfo.Name, fullOverlappingRanges.Count, partialOverlappingRanges.Count };
    }
}