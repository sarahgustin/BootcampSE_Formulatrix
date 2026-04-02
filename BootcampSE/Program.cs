using System;

namespace BootcampSE
{
 class Program
   {
       static void Main(string[] args)
        {
            //deklarasi array
            char [] vowels = new char [5] ;// bikin array charater berisi 5 
            int [] numbers = new int [10]; // bikin array int berisi 10
            string [] names = new string [7] ;// bikin array string isi 3

            //arrrayname.Lenght -> nunjuki jumlah element dalam array
            Console.WriteLine ($"Array vowel berisikan {vowels.Length} element");
            Console.WriteLine ($"Array nmbers berisikan {numbers.Length} element");
            Console.WriteLine ($"Array names berisikan {names.Length} element");
        }
       }
   }

