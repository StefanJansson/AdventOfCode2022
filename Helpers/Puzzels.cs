using System.Diagnostics;

namespace Helpers;

public static class Puzzels
{
    public static (bool FileExists, string FileName, string PuzzleName) GetPuzzleInfo()
    {
        var methodName = new StackFrame(1, false).GetMethod()!.DeclaringType!.Name;
        var fileName = $@"..\..\..\Inputs\{methodName}.txt";
        return (File.Exists(fileName), fileName, methodName);
    }
}