﻿Console.Write("Enter month (1-12): ");
int month = int.Parse(Console.ReadLine());
Console.Write("Enter day (1-31): ");
int day = int.Parse(Console.ReadLine());
if ((month == 3 && day >= 20) || (month == 4) || (month == 5) || (month == 6 && day <= 20))
{
    Console.WriteLine("It's a Spring Season");
}
else
{
    Console.WriteLine("Not a Spring Season");
}
