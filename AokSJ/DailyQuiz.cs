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
                .Select(_ => Regex.Matches(_, @"\d+").Select(_ => Convert.ToInt64(_.Value)).Sum())
                .OrderByDescending(_ => _).ToList();
            return new List<object>() { "2022-12-01", summaries.Max(), summaries.Take(3).Sum()};
        }

        public static List<object> Day02()
        {
            return new List<object>() { "2022-12-02", "", "" };
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
