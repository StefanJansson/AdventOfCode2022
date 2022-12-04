using System.Drawing;
using Helpers;

namespace Aok2015.Puzzles;

internal static class Day03
{
    public static List<object> Answer()
    {
        var puzzleInfo = Helpers.Puzzles.GetPuzzleInfo();
        if (!puzzleInfo.FileExists)
            return new List<object>() { puzzleInfo.Name };

        var directions = puzzleInfo.GetInputAsText();

        // Part One
        var locationDropsPartOne = new Dictionary<Point, int>();
        var currentPointPartOne = new Point();

        for (var direction = 0; direction < directions.Length; direction++)
        {
            switch (directions.Substring(direction, 1))
            {
                case ">":
                    currentPointPartOne.X++;
                    break;
                case "<":
                    currentPointPartOne.X--;
                    break;
                case "^":
                    currentPointPartOne.Y++;
                    break;
                case "v":
                    currentPointPartOne.Y--;
                    break;
                default:
                    throw new Exception("Invalid value");
            }
            if (locationDropsPartOne.ContainsKey(currentPointPartOne))
                locationDropsPartOne[currentPointPartOne]++;
            else
                locationDropsPartOne.Add(currentPointPartOne, 1);
        }

        // Part Two
        var locationDropsPartTwo = new Dictionary<Point, int>();

        var currentPointPartTwo = new Point[2];

        for (var direction = 0; direction < directions.Length; direction++)
        {
            switch (directions.Substring(direction, 1))
            {
                case ">":
                    currentPointPartTwo[direction % 2].X++;
                    break;
                case "<":
                    currentPointPartTwo[direction % 2].X--;
                    break;
                case "^":
                    currentPointPartTwo[direction % 2].Y++;
                    break;
                case "v":
                    currentPointPartTwo[direction % 2].Y--;
                    break;
                default:
                    throw new Exception("Invalid value");
            }
            if (locationDropsPartTwo.ContainsKey(currentPointPartTwo[direction % 2]))
                locationDropsPartTwo[currentPointPartTwo[direction % 2]]++;
            else
                locationDropsPartTwo.Add(currentPointPartTwo[direction % 2], 1);
        }
        
        return new List<object>() { puzzleInfo.Name, locationDropsPartOne.Count, locationDropsPartTwo.Count };
    }
}