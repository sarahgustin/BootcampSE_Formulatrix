using System;

namespace AdvanceCsharp;

class DelegateBaic
{   delegate int Transformer (int x); // define delegate

    //basid delegate
    public static void DelegateBasicRun()
    {
        Transformer t = Square; //short dari new Transformer (Square)

        int result = t(3); //panggil square(3) melaui delegate

        Console.WriteLine($"Square of 3 through delegate: {result}");

        t = Cube;
        result = t(3);
        Console.WriteLine($"Cube of 3 through same delegate: {result}");
            
        result = t.Invoke(4);
        Console.WriteLine($"Cube of 4 through same delegate: {result}");  

        t = Tambah;
        result = t(5);
        Console.WriteLine($"Penjumalahan 5 melalui delegate yang sama {result}");  
    }
    static int Square(int x) => x*x;
    static int Cube (int x) => x*x*x;
    static int Tambah (int x) => x+x;

    // end basic delegate

    //plugin method with delgate
    public static void PluginMethodDelegate()
    {
        int [] values = {1, 2, 3, 4, 5};
        Console.WriteLine($"Original values [{string.Join(",", values)}]");

        //Tranform array values menggunakan Square sebagai plugin
        Transform(values, Square);
        Console.WriteLine($"After Square transformer [{string.Join(",", values)}]");

        //reset values
        values = new int []{1, 2, 3, 4, 5 };

        Transform(values, Cube);
        Console.WriteLine($"After Cube transform: [{string.Join(", ", values)}]");
            
        // You can even pass lambda expressions as plugins
        values = new int[] { 1, 2, 3, 4, 5 };
        Transform(values, x => x + 10);  // Add 10 to each element
        Console.WriteLine($"After +10 transform: [{string.Join(", ", values)}]");
            
        Console.WriteLine();
    }   
    static void Transform(int[] values, Transformer t)
    {
        for (int i = 0; i < values.Length; i++)
            values[i] = t(values[i]);  // Apply the plugged-in transformation
            //tiap index dari value bakal di pass ke method yang di panggil oleh t.
    }
    //end plugin method with delegate


}