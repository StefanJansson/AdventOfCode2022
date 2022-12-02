using System.Diagnostics;

namespace AokBas;

public static class Helpers
{
    public static (bool FileExists, string FileName, string PuzzleName) GetPuzzleInfo()
    {
        var method = new StackFrame(2, false).GetMethod()!.DeclaringType!.Name;
        var fileName = $@"..\..\..\..\PuzzelInputs\{method}.txt";
        return (File.Exists(fileName), fileName, method);
    }
}