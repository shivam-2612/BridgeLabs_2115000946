﻿Console.Write("Enter a number: ");
int number = int.Parse(Console.ReadLine());
if (number > 0)
{
    Console.WriteLine("Positive");
}
else if (number < 0)
{
    Console.WriteLine("Negative");
}
else
{
    Console.WriteLine("Zero");
}
