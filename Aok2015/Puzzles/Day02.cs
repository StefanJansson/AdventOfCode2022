using System.Text.RegularExpressions;
using Helpers;

namespace Aok2015.Puzzles;

internal static class Day02
{
    public static List<object> Answer()
    {
        var puzzleInfo = Helpers.Puzzles.GetPuzzleInfo();
        if (!puzzleInfo.FileExists)
            return new List<object>() { puzzleInfo.Name };

        var fileData = puzzleInfo.GetInputAsList();

        var totalArea = 0;
        var totalRibbon = 0;
        foreach (var packageDimension in fileData)
        {
            var dimensions = Regex.Matches(packageDimension,@"\d+").Select(_ => Convert.ToInt32(_.Value)).OrderBy(_ => _).ToList();
            
            // Part One
            totalArea += dimensions[0] * dimensions[1] + 2 * (dimensions[0] * dimensions[1] +
                                                              dimensions[0] * dimensions[2] +
                                                              dimensions[1] * dimensions[2]);

            //Part Two
            totalRibbon += 2 * (dimensions[0] + dimensions[1]) + dimensions[0] * dimensions[1] * dimensions[2];
        }
        return new List<object>() { puzzleInfo.Name, totalArea, totalRibbon};
    }

}