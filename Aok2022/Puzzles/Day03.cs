using Helpers;

namespace Aok2022.Puzzles;

internal static class Day03
{
    public static List<object> Answer()
    {
        var puzzleInfo = Helpers.Puzzles.GetPuzzleInfo();
        if (!puzzleInfo.FileExists)
            return new List<object>() { puzzleInfo.Name };


        var rucksacks = puzzleInfo.GetInputAsList();

        // Part One
        var priorities = "_abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ".ToArray();
        var prioritySumPartOne = 0;

        foreach (var rucksack in rucksacks)
        {
            var firstCompartment = rucksack.ToArray().Take(rucksack.Length / 2);
            var secondCompartment = rucksack.ToArray().Skip(rucksack.Length / 2);
            var intersectedTypes = firstCompartment.Intersect(secondCompartment);
            
            foreach (var intersectedType in intersectedTypes)
                prioritySumPartOne += Array.IndexOf(priorities, intersectedType);
        }

        // Part Two
        var prioritySumPartTwo = 0;

        for (var i = 0; i < rucksacks.Count; i +=3)
        {
            var elfOne = rucksacks[i].ToCharArray();
            var elfTwo = rucksacks[i+1].ToCharArray();
            var elfThree = rucksacks[i+2].ToCharArray();
            
            var intersectedTypes = elfOne.Intersect(elfTwo).Intersect(elfThree);
            
            foreach (var intersectedType in intersectedTypes)
                prioritySumPartTwo += Array.IndexOf(priorities, intersectedType);
        }

        return new List<object>() { puzzleInfo.Name, prioritySumPartOne, prioritySumPartTwo };
    }
}