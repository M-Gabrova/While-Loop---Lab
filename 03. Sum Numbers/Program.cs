using System;

namespace _08._Graduation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine()); 
            int sum = 0;

            while (sum < number)
            { 
                int numberCurr = int.Parse(Console.ReadLine());
                sum+= numberCurr;
                
            }

            Console.WriteLine(sum);
        }
    }
}
