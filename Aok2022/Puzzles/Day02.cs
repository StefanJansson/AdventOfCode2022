using Helpers;

namespace Aok2022.Puzzles;

internal static class Day02
{
    public static List<object> Answer()
    {
        var puzzleInfo = Helpers.Puzzles.GetPuzzleInfo();
        if (!puzzleInfo.FileExists)
            return new List<object>() { puzzleInfo.Name };

        var fileData = puzzleInfo.GetInputAsList();

        var opponentRockCode = "A";
        var opponentPaperCode = "B";
        var opponentScissorCode = "C";
        var myRockCode = "X";
        var myPaperCode = "Y";
        var myScissorCode = "Z";

        var opponentOptionCodes = new[] { opponentRockCode, opponentPaperCode, opponentScissorCode };
        var myOptionCodes = new[] { myRockCode, myPaperCode, myScissorCode };
        var winningResults = new[] { $"{opponentRockCode} {myPaperCode}", $"{opponentPaperCode} {myScissorCode}", $"{opponentScissorCode} {myRockCode}" };
        var tieResults = new[] { $"{opponentRockCode} {myRockCode}", $"{opponentPaperCode} {myPaperCode}", $"{opponentScissorCode} {myScissorCode}" };


        // Part One
        var choiceBonusesPartOne =
            fileData.Count(_ => _.EndsWith(myRockCode)) +
            2 * fileData.Count(_ => _.EndsWith(myPaperCode)) +
            3 * fileData.Count(_ => _.EndsWith(myScissorCode));

        var wonMatchesPartOne = fileData.Count(_ => winningResults.Contains(_));
        var tiedMatchesPartOne = fileData.Count(_ => tieResults.Contains(_));

        // Part Two
        var looseCode = "X";
        var tieResultCode = "Y";
        var winResultCode = "Z";
        var expectedResults = new[] { tieResultCode, winResultCode, looseCode };

        for (var i = 0; i < fileData.Count; i++)
        {
            fileData[i] = fileData[i][..2] +
                          myOptionCodes[
                              (Array.IndexOf(opponentOptionCodes, fileData[i][..1]) +
                               Array.IndexOf(expectedResults, fileData[i][2..3])) % 3];
        }

        var wonMatchesPartTwo = fileData.Count(_ => winningResults.Contains(_));
        var tiedMatchesPartTwo = fileData.Count(_ => tieResults.Contains(_));

        var choiceBonusesPartTwo =
            fileData.Count(_ => _.EndsWith(myRockCode)) +
            2 * fileData.Count(_ => _.EndsWith(myPaperCode)) +
            3 * fileData.Count(_ => _.EndsWith(myScissorCode));

        return new List<object>() { puzzleInfo.Name, choiceBonusesPartOne + 6 * wonMatchesPartOne + 3 * tiedMatchesPartOne, choiceBonusesPartTwo + 6 * wonMatchesPartTwo + 3 * tiedMatchesPartTwo };
    }
}