﻿using System;

class Program
{
    static string LongestWord(string sentence)
    {
        string[] words = sentence.Split(' ');
        string longest = "";

        foreach (string word in words)
        {
            if (word.Length > longest.Length) longest = word;
        }
        return longest;
    }

    static void Main()
    {
        Console.Write("Enter a sentence: ");
        string input = Console.ReadLine();
        Console.WriteLine("Longest Word: " + LongestWord(input));
    }
}
