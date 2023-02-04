using System;

namespace _08._Graduation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input;
            double sum = 0;
            while ((input = Console.ReadLine()) != "NoMoreMoney")
            {
                double currentSum = double.Parse(input);

                if (currentSum < 0)
                {
                    Console.WriteLine("Invalid operation!");
                    break;

                }        
                
                sum += currentSum;
                Console.WriteLine($"Increase: {currentSum:f2}");
            }
            Console.WriteLine($"Total: {sum:f2}");



        }
    }
}
