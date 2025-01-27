﻿using System;

class Program
{
    public static void Main(string[] args)
    {
        Console.Write("Enter a number: ");
        int number = int.Parse(Console.ReadLine());
        int greatestFactor = 1;

        for (int i = number - 1; i > 1; i--)
        {
            if (number % i == 0)
            {
                greatestFactor = i;
                break;
            }
        }
        Console.WriteLine($"Greatest factor besides itself: {greatestFactor}");
    }
}
