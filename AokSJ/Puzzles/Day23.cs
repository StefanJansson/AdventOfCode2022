﻿namespace AokSJ.Puzzles;

internal class Day23
{
    public static List<object> Answer()
    {
        var puzzelInfo = Helpers.GetPuzzleInfo();
        if (!puzzelInfo.FileExists)
            return new List<object>() { puzzelInfo.PuzzleName };

        return new List<object>() { puzzelInfo.PuzzleName, "", "" };
    }
}