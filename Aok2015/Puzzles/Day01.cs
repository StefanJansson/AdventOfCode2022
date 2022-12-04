using System.Net;
using System.Text.RegularExpressions;
using Helpers;

namespace Aok2015.Puzzles;

internal static class Day01
{
    public static List<object> Answer()
    {
        var puzzleInfo = Helpers.Puzzles.GetPuzzleInfo();
        if (!puzzleInfo.FileExists)
            return new List<object>() { puzzleInfo.Name };

        var fileData = puzzleInfo.GetInputAsText();

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
        return new List<object>() { puzzleInfo.Name, finalFloor, directionNumber };
    }

}