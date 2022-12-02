namespace Aok2022.Puzzles;

internal class Day21
{
    public static List<object> Answer()
    {
        var puzzelInfo = Helpers.Puzzels.GetPuzzleInfo();
        if (!puzzelInfo.FileExists)
            return new List<object>() { puzzelInfo.PuzzleName };

        return new List<object>() { puzzelInfo.PuzzleName, "", "" };
    }
}