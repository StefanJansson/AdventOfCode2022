using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace AokSJ.Puzzles
{
    internal class Day01
    {
        public static List<object> Answer()
        {
            var fileData = System.IO.File.ReadAllText(@"..\..\..\..\PuzzelInputs\2022-12-01.txt");
            var splitFileData = fileData.Split("\n\n");
            var summaries = splitFileData
                .Select(_ => Regex.Matches(_, @"\d+")
                    .Select(_ => Convert.ToInt64(_.Value)).Sum())
                .OrderByDescending(_ => _)
                .ToList();
            return new List<object>() { "2022-12-01", summaries.First(), summaries.Take(3).Sum() };
        }

    }
}
