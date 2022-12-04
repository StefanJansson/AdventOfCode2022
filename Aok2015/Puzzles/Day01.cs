using System.Net;
using System.Text.RegularExpressions;

namespace Aok2015.Puzzles;

internal class Day01
{
    public static List<object> Answer()
    {
        var puzzelInfo = Helpers.Puzzels.GetPuzzleInfo();
        if (!puzzelInfo.FileExists)
            return new List<object>() { puzzelInfo.PuzzleName };

        var fileData = File.ReadAllText(puzzelInfo.FileName);

        // Part One
        var ups = Regex.Matches(fileData, @"\(").Count;
        var downs = Regex.Matches(fileData, @"\)".ToString()).Count;
        var finalFloor = ups - downs;

        // Part Two
        var directionNumber = 0;
        var floor = 0;
        while (floor != -1)
        {
            if (fileData.Substring(directionNumber, 1) == "(")
                floor++;
            else
                floor--;
            directionNumber++;
        }
        return new List<object>() { puzzelInfo.PuzzleName, finalFloor, directionNumber };
    }

}