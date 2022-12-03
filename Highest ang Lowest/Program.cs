using System;
using System.Linq;

namespace Highest_ang_Lowest
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(HighAndLow("8 3 -5 42 -1 0 0 -9 4 7 4 -4"));

        }
        // MyMestod
        public static string HighAndLow(string numbers)
        {
            string[] number = numbers.Split(new char[] { ' ' });

            int min = int.Parse(number[0]);
            int max = int.Parse(number[0]);
            foreach (string num in number)
            {
                if (min > int.Parse(num))
                    min = int.Parse(num);

                if (max < int.Parse(num))
                    max = int.Parse(num);
            }

            return $"{max} {min}";
        }
        // More Clever method
        public static string HighAndLow1(string numbers)
        {
            var parsed = numbers.Split().Select(int.Parse);
            return parsed.Max() + " " + parsed.Min();
        }
        
    }
}
