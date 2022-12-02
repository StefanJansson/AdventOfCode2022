using System.Diagnostics;

namespace AokSJ;

public static class Helpers
{
    public static (bool FileExists, string FileName, string PuzzleName) GetPuzzleInfo()
    {
        var methodName = new StackFrame(1, false).GetMethod()!.DeclaringType!.Name;
        var fileName = $@"..\..\..\..\PuzzelInputs\{methodName}.txt";
        return (File.Exists(fileName), fileName, methodName);
    }
}