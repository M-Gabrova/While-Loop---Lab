using System;

namespace _06._Max_Number
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int minNumber = int.MaxValue;

            string input;

            while ((input = Console.ReadLine()) != "Stop")
            {
                int currNumber = int.Parse(input);
                if (currNumber < minNumber)
                {
                    minNumber = currNumber;
                }

            }
            Console.WriteLine(minNumber);
        }
    }
}
