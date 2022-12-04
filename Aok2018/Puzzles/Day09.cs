namespace Aok2018.Puzzles;

internal static class Day09
{
    public static List<object> Answer()
    {
        var puzzleInfo = Helpers.Puzzles.GetPuzzleInfo();
        if (!puzzleInfo.FileExists)
            return new List<object>() { puzzleInfo.Name };

        return new List<object>() { puzzleInfo.Name, "", "" };
    }
}