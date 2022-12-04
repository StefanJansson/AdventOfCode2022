using System.Text.RegularExpressions;

namespace Aok2015.Puzzles;

internal class Day02
{
    public static List<object> Answer()
    {
        var puzzelInfo = Helpers.Puzzels.GetPuzzleInfo();
        if (!puzzelInfo.FileExists)
            return new List<object>() { puzzelInfo.PuzzleName };

        var fileData = File.ReadAllLines(puzzelInfo.FileName);

        var totalArea = 0;
        var totalRibbon = 0;
        foreach (var packageDimension in fileData)
        {
            var dimensions = Regex.Matches(packageDimension,@"\d+").Select(_ => Convert.ToInt32(_.Value)).OrderBy(_ => _).ToList();
            totalArea += dimensions[0] * dimensions[1] + 2 * (dimensions[0] * dimensions[1] +
                                                              dimensions[0] * dimensions[2] +
                                                              dimensions[1] * dimensions[2]);
            totalRibbon += 2 * (dimensions[0] + dimensions[1]) + dimensions[0] * dimensions[1] * dimensions[2];
        }
        return new List<object>() { puzzelInfo.PuzzleName, totalArea, totalRibbon};
    }

}