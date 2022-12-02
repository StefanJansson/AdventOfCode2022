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
    }
}
