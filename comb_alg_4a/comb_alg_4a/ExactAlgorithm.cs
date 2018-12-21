﻿using System;
using System.Collections.Generic;
using System.Diagnostics;

namespace comb_alg_4a
{
    class ExactAlgorithm
    {
        static bool found;
        static int[] answer;

        public static string ToString(int[] perm)
        {
            int n = perm.Length;
            string result = perm[0].ToString();
            for (int i = 1; i < n; i++)
                result += " " + perm[i];
            return result;
        }

        public static string Result(int[] set, int sum, out long time, out int realDiff)
        {
            time = 0;
            Stopwatch stopWatch = new Stopwatch();
            stopWatch.Start();

            found = false;
            realDiff = 0; //тк получаем точное значение

            List<int> curSubSet = new List<int>();
            
            isSubsetSum(set, sum, curSubSet, 0, 0);

            if (answer == null) //не нашли ответа - значит погрешность = искомой сумме
            {
                realDiff = sum;
            }

            stopWatch.Stop();
            time = stopWatch.Elapsed.Ticks;

            if (answer == null)
            {
                return "Не возможно получить точное значение суммы";
            }
            return ToString(answer);
        }

        private static void isSubsetSum(int[] set, int targetSum, List<int> curSubSet, int i, int curSum)
        {
            if (curSum == targetSum)
            {
                answer = new int[curSubSet.Count];
                curSubSet.CopyTo(answer);
                found = true;
                return;
            }
            else
            {
                for (int j = i; j < set.Length && !found; j++)
                {
                    if (curSum + set[j] <= targetSum)
                    {
                        curSubSet.Add(set[j]);
                        isSubsetSum(set, targetSum, curSubSet, j + 1, curSum + set[j]);
                        curSubSet.Remove(set[j]);
                    }
                    else
                    {
                        isSubsetSum(set, targetSum, curSubSet, j + 1, curSum);
                    }
                }
                return;

            }
        }


    }
}
