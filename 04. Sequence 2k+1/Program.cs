﻿using System;

namespace _08._Graduation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            int k = 1;

            while (k <= number)
            {   
                Console.WriteLine(k);
                k = k * 2 + 1;
            }


        }
    }
}
