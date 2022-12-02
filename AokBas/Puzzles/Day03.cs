﻿namespace AokBas.Puzzles;

internal class Day03
{
    public static List<object> Answer()
    {
        var puzzelInfo = Helpers.GetPuzzleInfo();
        if (!puzzelInfo.FileExists)
            return new List<object>() { puzzelInfo.PuzzleName};

        return new List<object>() { puzzelInfo.PuzzleName, "", "" };
    }
}