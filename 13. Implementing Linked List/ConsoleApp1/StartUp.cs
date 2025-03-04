﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Threading;
using System.Timers;

namespace CustomDoublyLinkedList
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            int arraySize = 100;
            int testsCount = 20;
            int arraySizeStep = 10;

            for (int i = 10; i < arraySize; i += arraySizeStep)
            {
                int[] ints = new int[i];

                for (int j = 0; j < i; j++)
                {
                    ints[j] += j + 1;
                }

                CustomDublyLinkedList list1 = new CustomDublyLinkedList(ints);
                List<int> list2 = new List<int>(ints);

                long[,] times = new long[testsCount, 2];

                for (int j = 0; j < testsCount; j++)
                {
                    for (int k = 0; k < 2; k++)
                    {
                        Stopwatch timer = new Stopwatch();
                        timer.Start();

                        if (k == 0)
                        {
                            list1.ForEach(x => Console.WriteLine(x));
                        }
                        else
                        {
                            list2.ForEach(x => Console.WriteLine(x));
                        }

                        timer.Stop();
                        times[j, k] = timer.ElapsedMilliseconds;


                        timer.Reset();
                        Console.Clear();

                    }
                }

                long list1Avg = 0;
                long list2Avg = 0;

                for (int j = 0; j < testsCount; j++)
                {
                    for (int k = 0; k < 2; k++)
                    {
                        if (k == 0)
                        {
                            list1Avg += times[j, k];
                        }
                        else
                        {
                            list2Avg += times[j, k];
                        }
                    }
                }

                decimal list1Average = Math.Round((decimal)(list1Avg / testsCount),2);
                decimal list2Average = Math.Round((decimal)(list1Avg / testsCount), 2);

            }
        }
    }
}
