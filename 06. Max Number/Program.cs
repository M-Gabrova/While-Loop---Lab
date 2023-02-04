using System;

namespace _06._Max_Number
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int maxNumber = int.MinValue;

            string input;

            while ((input = Console.ReadLine()) != "Stop")
            {
                int currNumber = int.Parse(input);
                if (currNumber > maxNumber) 
                {
                    maxNumber= currNumber;
                }

            }
            Console.WriteLine(maxNumber);
        }
    }
}
