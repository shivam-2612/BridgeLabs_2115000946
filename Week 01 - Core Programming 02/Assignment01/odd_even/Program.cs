﻿Console.Write("Enter a number: ");
int n = int.Parse(Console.ReadLine());
if (n > 0)
{
    for (int i = 1; i <= n; i++)
    {
        if (i % 2 == 0)
            Console.WriteLine($"{i} is even");
        else
            Console.WriteLine($"{i} is odd");
    }
}
else
{
    Console.WriteLine("Not a natural number");
}
