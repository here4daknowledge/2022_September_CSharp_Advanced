﻿using System;
using System.Linq;

namespace _03.Largest3Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] input = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int[] sorted = input.OrderByDescending(x => x).Take(3).ToArray();
            Console.WriteLine(String.Join(' ', sorted));
        }   
    }
}
