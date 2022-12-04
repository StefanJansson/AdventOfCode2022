using System.Drawing;

namespace Aok2015.Puzzles;

internal class Day03
{
    public static List<object> Answer()
    {
        var puzzelInfo = Helpers.Puzzels.GetPuzzleInfo();
        if (!puzzelInfo.FileExists)
            return new List<object>() { puzzelInfo.PuzzleName };

        var directions = File.ReadAllText(puzzelInfo.FileName);

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


        return new List<object>() { puzzelInfo.PuzzleName, locationDropsPartOne.Count, locationDropsPartTwo.Count };
    }
}