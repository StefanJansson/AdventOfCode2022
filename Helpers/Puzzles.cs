using System.Diagnostics;
using System.Runtime.CompilerServices;

namespace Helpers;

public static class Puzzles
{
    public static PuzzleInfo GetPuzzleInfo()
    {
        var methodName = new StackFrame(1, false).GetMethod()!.DeclaringType!.Name;
        var fileName = $@"..\..\..\Inputs\{methodName}.txt";
        return new PuzzleInfo(File.Exists(fileName), fileName, methodName);
    }

    public class PuzzleInfo
    {
        public PuzzleInfo(bool fileExists, string fileName, string name)
        {
            FileExists = fileExists;
            FileName = fileName;
            Name = name;
        }

        public bool FileExists { get; }
        public string FileName { get; }
        public string Name { get; }
    }

    // Extensions
    public static List<string> GetInputAsList(this PuzzleInfo puzzleInfo)
        => File.ReadAllLines(puzzleInfo.FileName).ToList();
    public static string GetInputAsText(this PuzzleInfo puzzleInfo)
        => File.ReadAllText(puzzleInfo.FileName);
}