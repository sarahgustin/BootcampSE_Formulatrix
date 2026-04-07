using System;

namespace AdvanceCsharp;

class MultiDelegates
{   
    delegate void ProgressReporter (int percentComplete); //tanpa return value
    delegate int Transformer (int x); // define delegate
    public static void MultiDelegatesRun()
    {
        //single method
        ProgressReporter reporter = WriteProgressToConsole;

        reporter += WriteProgressToFile;
        reporter += SendProgressAlert; 

        Console.WriteLine("Progress reporting with multicast delegate (3 methods):");
        reporter (50); //SendProgressAlert ngga akan ke print karena kurang dari 75


        Console.WriteLine("\nRemoving console reporter using -= operator:");
        reporter -= WriteProgressToConsole;

        Console.WriteLine("Progress reporting after removal (2 methods):");
        if (reporter != null)
            reporter(75);

        // Demonstrate that return values are lost in multicast (except the last one)
        Console.WriteLine("\nMulticast with return values (only last one is kept):");
        Transformer multiTransformer = Square;
        multiTransformer += Cube;  // Now has two methods
            
        int lastResult = multiTransformer(3);  // Calls Square(3) then Cube(3)
        Console.WriteLine($"Only the last result is returned: {lastResult}");  // Will be 27 (cube), not 9 (square)
            
        Console.WriteLine();    

    }

    static int Square(int x) => x*x;
    static int Cube (int x) => x*x*x;
    static void WriteProgressToConsole (int percentComplete)
    {
         Console.WriteLine($"  Console Log: {percentComplete}% complete");
    }

    static void WriteProgressToFile(int percentComplete)
    {
        Console.WriteLine($"  File Log: Writing {percentComplete}% to progress.log");
    }
    static void SendProgressAlert (int percentComplete)
    {
        if (percentComplete >= 75)
            Console.WriteLine($"  Alert: High progress reached - {percentComplete}%!");
    }


}
