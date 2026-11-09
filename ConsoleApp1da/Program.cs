using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static int n;
    static int[] a;

    static void Generate(int index)
    {
        if (index == n)
        {
            for (int i = 0; i < n; i++)
                Console.Write(a[i]);

            Console.WriteLine();
            return;
        }

        for (int digit = 0; digit <= 1; digit++)
        {
            a[index] = digit;
            Generate(index + 1);
        }
    }

    static void Main()
    {
        Console.Write("Въведете n: ");
        n = int.Parse(Console.ReadLine());

        if (n < 0)
        {
            Console.WriteLine("n трябва да е неотрицателно.");
            return;
        }

        a = new int[n];
        Generate(0);
    }
}
