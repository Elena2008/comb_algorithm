using System;

namespace combLabFirst
{
    public class Perm
    {

        public static string PermToString(int[] perm){
            int n = perm.Length;
            string result = perm[0].ToString();
            for (int i = 1; i < n; i++)
                result += " " + perm[i];
            return result;
        }

        public static void Swap(ref int[] perm, int i, int j)
        {
            int tmp = perm[i];
            perm[i] = perm[j];
            perm[j] = tmp;
        }

        public static int[] GetFirstPerm(int n)
        {
            int[] arr = new int[n];
            arr[0] = 0; //пусть первым посадили гостя номер 0; по сути за круглым столом это не имеет значения
            for (int i = 1; i < n; i++)
            {
                arr[i] = i;
            }
            return arr;
        }

        public static Boolean GetNextPerm(ref int[] perm)
        {
            int n = perm.Length;
            int i = n - 1;
            for (; i > 1 && perm[i] < perm[i - 1]; i--) ;
            if (i == 1)
                return false;
            int j = n - 1;
            for (; j >= 1 && perm[j] < perm[i - 1]; j--) ;
            Swap(ref perm, i - 1, j);
            
            for (int k = 0; k <= (n - i) / 2 - 1; k++)
            {
                Swap(ref perm, k + i, n - k - 1);
            }
            return true;
        }

    }
}
