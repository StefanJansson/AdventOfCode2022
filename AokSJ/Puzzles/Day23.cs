using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AokSJ.Puzzles
{
    internal class Day23
    {
        public static List<object> Answer()
        {
            var date = $"2022-12-{System.Reflection.MethodBase.GetCurrentMethod().DeclaringType.Name.Substring(3, 2)}";
            var fileName = @"..\..\..\..\PuzzelInputs\{date}.txt";
            if (!System.IO.File.Exists(fileName))
                return new List<object>() { date };

            var fileData = System.IO.File.ReadAllLines($@"..\..\..\..\PuzzelInputs\{date}.txt").ToList();
            return new List<object>() { date, "", "" };
        }
    }
}
