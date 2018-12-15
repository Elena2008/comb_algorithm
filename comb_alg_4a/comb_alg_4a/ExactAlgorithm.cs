using System.Collections.Generic;
using System.Diagnostics;

namespace comb_alg_4a
{
    class ExactAlgorithm
    {
        static bool found;
        static List<int> answer;
       
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

            answer = new List<int>();
            found = false;

            realDiff = 0; //тк получаем точное значение

            List<int> curSubSet = new List<int>();            
            isSubsetSum(set, sum, curSubSet);

            if (answer == null) //не нашли ответа - значит погрешность = искомой сумме
            {
                realDiff = sum;
            }         
            
            stopWatch.Stop();
            time = stopWatch.ElapsedTicks;

            if (answer == null) {
                return "Не возможно получить точное значение суммы";
            }
            return ToString(answer.ToArray());
        }

        private static bool isSubsetSum(int[] set, int sum, List<int> curSubSet)
        {
            for (int i = 0; i < set.Length && answer.Count < set.Length; i++)
            {
                if (!found)
                {
                    if (!curSubSet.Contains(set[i])) //если такой эл. еще не содержится в подмножестве
                    {
                        curSubSet.Add(set[i]);
                        if (sum == set[i])
                        {
                            foreach (int el in curSubSet)
                            {
                                answer.Add(el);
                            }
                            return true;
                        }
                        else
                        {
                            found = isSubsetSum(set, sum - set[i], curSubSet);
                            curSubSet.Remove(set[i]);
                        }
                    }
                }
            }      
            return found;
        }


        /*
         * динамич
        static int[,] matr;
        static List<int> curSubSet = new List<int>();

        public static string Result(int[] set, int sum, out long time, out int realSum)
        {
            //подсчет времени
            time = 0;
            Stopwatch stopWatch = new Stopwatch();
            stopWatch.Start();
            realSum = 0;

            matr = new int[set.Length + 1, sum + 1];

            for (int i = 0; i <= set.Length; i++)
            {
                matr[i, 0] = 0;
            }

            for (int i = 0; i <= sum; i++)
            {
                matr[0, i] = 0;
            }

            for (int i = 1; i <= set.Length; i++)
            {
                for (int j = 1; j <= sum; j++)
                {
                    if (j - set[i - 1] >= 0)
                    {
                        matr[i, j] = Math.Max(matr[i - 1, j], matr[i - 1, j - set[i - 1]] + set[i - 1]);
                    }
                    else matr[i, j] = matr[i - 1, j];
                }
            }

            getSubSet(set.Length, sum, set);
            realSum = sum - matr[set.Length, sum];
            //конец времени
            stopWatch.Stop();
            time = stopWatch.ElapsedTicks;
            return ToString(curSubSet.ToArray());
        }

        public static void getSubSet(int i, int j, int[] set)
        {
            if (matr[i, j] == 0)
                return;
            if (matr[i - 1, j] == matr[i, j])
                getSubSet(i - 1, j, set);
            else
            {
                getSubSet(i - 1, j - set[i - 1], set);
                curSubSet.Add(set[i - 1]);
            }

        }*/


    }
}
