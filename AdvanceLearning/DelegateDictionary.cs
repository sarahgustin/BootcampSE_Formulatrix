using System;

namespace AdvanceCsharp;

class DelegateDictionary
{   delegate int Transformer (int x); // define delegate
    public static void DelegateDictionaryRun()
    {
        var perhitungan = new Dictionary <string, Transformer>
        {
            {"Luas", Square},
            {"Volume", Cube},
            {"Tambah", Plus}
        };

        int value = 5;
        int result = perhitungan["Luas"](value); //pilih method di dictionary dan masukin value melalui delegate

        Console.WriteLine($"Hasil luas dari {value} adalah : {result}");

        int [] values = {1,2,3,4,5}; 

        string pilihanUser = "Volume"; 
        Transform(values, perhitungan[pilihanUser]);
        Console.WriteLine($"Hasil {pilihanUser}: [{string.Join(", ", values)}]");
    }

    static int Square(int x) => x*x;
    static int Cube (int x) => x*x*x;
    static int Plus (int x) => x+x;

    static void Transform(int [] values, Transformer t)
    {
         for (int i = 0; i < values.Length; i++)
            values[i] = t(values[i]);  // Apply the plugged-in transformation
            //tiap index dari value bakal di pass ke method yang di panggil oleh t.
    }

}
