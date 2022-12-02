using System.Text.RegularExpressions;

namespace AokSJ
{
    public class DailyQuiz
    {
        public static List<object> Day01()
        {
            var fileData = System.IO.File.ReadAllText(@"..\..\..\Files\2022-12-01.txt");
            var splitFileData = fileData.Split("\n\n");
            var summaries = splitFileData
                .Select(_ => Regex.Matches(_, @"\d+")
                .Select(_ => Convert.ToInt64(_.Value)).Sum())
                .OrderByDescending(_ => _)
                .ToList();
            return new List<object>() { "2022-12-01", summaries.First(), summaries.Take(3).Sum() };
        }

        public static List<object> Day02()
        {
            var fileData = System.IO.File.ReadAllLines(@"..\..\..\Files\2022-12-02.txt").ToList();

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
                fileData[i] = fileData[i].Substring(0, 2) +
                              myOptionCodes[
                                  (Array.IndexOf(opponentOptionCodes, fileData[i].Substring(0, 1)) +
                                   Array.IndexOf(expectedResults, fileData[i].Substring(2, 1))) % 3];
                
            }

            var wonMatchesPartTwo = fileData.Count(_ => winningResults.Contains(_));
            var tiedMatchesPartTwo = fileData.Count(_ => tieResults.Contains(_));
            
            var choiceBonusesPartTwo =
                fileData.Count(_ => _.EndsWith(myRockCode)) +
                2 * fileData.Count(_ => _.EndsWith(myPaperCode)) +
                3 * fileData.Count(_ => _.EndsWith(myScissorCode));

            return new List<object>() { "2022-12-02", choiceBonusesPartOne + 6 * wonMatchesPartOne + 3 * tiedMatchesPartOne, choiceBonusesPartTwo + 6 * wonMatchesPartTwo + 3 * tiedMatchesPartTwo };
        }

        public static List<object> Day03()
        {
            return new List<object>() { "2022-12-03", "", "" };
        }

        public static List<object> Day04()
        {
            return new List<object>() { "2022-12-04", "", "" };
        }

        public static List<object> Day05()
        {
            return new List<object>() { "2022-12-05", "", "" };
        }

        public static List<object> Day06()
        {
            return new List<object>() { "2022-12-06", "", "" };
        }

        public static List<object> Day07()
        {
            return new List<object>() { "2022-12-07", "", "" };
        }

        public static List<object> Day08()
        {
            return new List<object>() { "2022-12-08", "", "" };
        }

        public static List<object> Day09()
        {
            return new List<object>() { "2022-12-09", "", "" };
        }

        public static List<object> Day10()
        {
            return new List<object>() { "2022-12-10", "", "" };
        }

        public static List<object> Day11()
        {
            return new List<object>() { "2022-12-11", "", "" };
        }

        public static List<object> Day12()
        {
            return new List<object>() { "2022-12-12", "", "" };
        }

        public static List<object> Day13()
        {
            return new List<object>() { "2022-12-13", "", "" };
        }

        public static List<object> Day14()
        {
            return new List<object>() { "2022-12-14", "", "" };
        }

        public static List<object> Day15()
        {
            return new List<object>() { "2022-12-15", "", "" };
        }

        public static List<object> Day16()
        {
            return new List<object>() { "2022-12-16", "", "" };
        }

        public static List<object> Day17()
        {
            return new List<object>() { "2022-12-17", "", "" };
        }

        public static List<object> Day18()
        {
            return new List<object>() { "2022-12-18", "", "" };
        }

        public static List<object> Day19()
        {
            return new List<object>() { "2022-12-19", "", "" };
        }

        public static List<object> Day20()
        {
            return new List<object>() { "2022-12-20", "", "" };
        }

        public static List<object> Day21()
        {
            return new List<object>() { "2022-12-21", "", "" };
        }

        public static List<object> Day22()
        {
            return new List<object>() { "2022-12-22", "", "" };
        }

        public static List<object> Day23()
        {
            return new List<object>() { "2022-12-23", "", "" };
        }

        public static List<object> Day24()
        {
            return new List<object>() { "2022-12-24", "", "" };
        }

    }
}
