﻿using System;

class Program {
    static void Main() {
        int[] ages = new int[10];
        for (int i = 0; i < ages.Length; i++) {
            Console.Write($"Enter age of student {i + 1}: ");
            ages[i] = int.Parse(Console.ReadLine());
        }

        foreach (var age in ages) {
            if (age < 0) {
                Console.WriteLine($"Invalid age: {age}");
            } else if (age >= 18) {
                Console.WriteLine($"The student with the age {age} can vote.");
            } else {
                Console.WriteLine($"The student with the age {age} cannot vote.");
            }
        }
    }
}
