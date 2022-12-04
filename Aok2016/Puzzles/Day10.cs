namespace Aok2016.Puzzles;

internal static class Day10
{
    public static List<object> Answer()
    {
        var puzzleInfo = Helpers.Puzzles.GetPuzzleInfo();
        if (!puzzleInfo.FileExists)
            return new List<object>() { puzzleInfo.Name };

        return new List<object>() { puzzleInfo.Name, "", "" };
    }
}