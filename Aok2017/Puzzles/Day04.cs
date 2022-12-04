namespace Aok2017.Puzzles;

internal static class Day04
{
    public static List<object> Answer()
    {
        var puzzleInfo = Helpers.Puzzles.GetPuzzleInfo();
        if (!puzzleInfo.FileExists)
            return new List<object>() { puzzleInfo.Name };

        return new List<object>() { puzzleInfo.Name, "", "" };
    }
}