using System.Collections.Generic;

namespace combLabFirst
{
    class Guests
    {

        int[,] relations;
        List<int[]> result = new List<int[]>();

        public Guests(int[,] _relations)
        {
            relations = _relations;
        }

        //проверка удовлетворяет ли перестановка заданным отношениям между гостями
        private bool CheckRelation(int[] comb)
        {
            int n = comb.Length-1;
            if (relations[comb[0], comb[n]] == 2)
                return false;

            for (int j = 1; j < n; j++)
            {
                if (relations[comb[0], j] == 1)
                    if (comb[1] != j && comb[n] != j)
                        return false;
            }

            for (int i = 0; i < n; i++)
            {
                if (relations[comb[i], comb[i+1]] == 2)
                    return false;                   
            }
           
            for (int i = 1; i < n - 1; i++)
            {
                for (int j = 1; j <= n; j++)
                {
                    if (relations[comb[i], j] == 1 && comb[i + 1] != j)
                        return false;
                }
            }

            foreach (var el in result)
            {
                for (int i = 1; i < n / 2 + 1; i++)
                    if (el[i] == comb[n - i + 1])
                        return false;
            }

            return true;
        }

        public List<int[]> DoTask()
        {
            int cntGuests = relations.GetLength(0);
            int[] combination = Perm.GetFirstPerm(cntGuests);

            do
            {
                if (CheckRelation(combination))
                {
                    result.Add((int[])combination.Clone());
                }
            } while (Perm.GetNextPerm(ref combination));
            return result;
        }

    }
}
