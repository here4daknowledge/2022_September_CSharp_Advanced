﻿using System;
using System.Linq;

namespace _04.GenericSwapMethodInteger
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            Box<int> box = new Box<int>();

            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                box.Add(int.Parse(Console.ReadLine()));
            }

            int[] indexes = Console.ReadLine().Split().Select(int.Parse).ToArray();

            box.SwapElements(indexes[0], indexes[1]);

            Console.WriteLine(box);
        }
    }
}
