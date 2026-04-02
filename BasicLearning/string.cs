using System;
class LatihanStringVariable
{
    public static void StringVariable()
    {
        char[] vowels = new char[5];// bikin array charater berisi 5 
        int[] numbers = new int[10]; // bikin array int berisi 10
        string[] names = new string[7];// bikin array string isi 3

        //arrrayname.Lenght -> nunjuki jumlah element dalam array
        Console.WriteLine($"Array vowel berisikan {vowels.Length} element");
        Console.WriteLine($"Array nmbers berisikan {numbers.Length} element");
        Console.WriteLine($"Array names berisikan {names.Length} element");

        //  inisialisasi array int
        int[] oddNumber = { 1, 3, 5, 7, 9 }; //inisialisasi kalo tau pasti isi dari array
        //cetak array int menggunakan for loop
        Console.Write("Ood Number : ");
        for (int i = 0; i < oddNumber.Length; i++)
        {
            Console.Write(oddNumber[i] + " ");
        }
        Console.WriteLine();  

        //inisialisasi array char 
        char [] consonant = {'g', 'h', 'j', 'k','l','m','n'};
        Console.WriteLine($"Consonant : {string.Join(", ", consonant)}");//string join tuh buat 

       //Array diisi setelah di declare
        int [] fibonacci = new int [10];//array fibonacci int berisi 10 element;
        // value dua element pertama di assaign secara manual
        fibonacci[0]=0;
        fibonacci[1]=1;
        //element selanjutnya di assign menggunakan for loop untuk menemukan bilangan fibonacci
        for (int i = 2; i < fibonacci.Length; i++)
        {
            fibonacci[i]=fibonacci[i-1]+fibonacci[i-2];
        }
        Console.WriteLine("Fibonacci : ");
        foreach (int item in fibonacci)
        {
            Console.Write(item +  " ");
        }

        string mixed = "Hello World";

        string upper = mixed.ToUpper();                    // "HELLO WORLD"
        string lower = mixed.ToLower();                    // "hello world"
        string upperInvariant = mixed.ToUpperInvariant();  // Culture-independent
        string lowerInvariant = mixed.ToLowerInvariant();  // Culture-independent
        Console.WriteLine(upper);
        Console.WriteLine(lower);
        Console.WriteLine(upperInvariant);
        Console.WriteLine(lowerInvariant);
    }
}