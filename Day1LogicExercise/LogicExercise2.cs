using System;

namespace LogicExercise
{
    public class LogicExercise2
    {
        public static void LogicExerciseRun()
        {
            Console.WriteLine("Masukkan Nilai : ");
            int n = Convert.ToInt32(Console.ReadLine());

            List<string> results = new List<string>();

            for (int x = 1; x <= n; x++)
            {
                string output = "";

                if (x % 3 == 0)
                    output += "foo";

                if (x % 5 == 0)
                    output += "bar";

                if (x % 7 == 0)
                    output += "jazz";

                if (output == "")
                    output = x.ToString();

                results.Add(output);
            }

            Console.WriteLine(string.Join(", ", results));
        }
    }
}