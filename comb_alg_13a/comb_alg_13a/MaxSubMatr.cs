using System;

namespace comb_alg_13a
{
    class MaxSubMatr
    {
        private int startX = 0;
        private int endX = 0;
        private int startY = 0;
        private int endY = 0;

        private int maxSum = Int32.MinValue;
        private int[][] original;  // матрица, в которой ищем

        int nStr, // количество строк в подматрице
            nCol; // количество столбцов

        public int m { get { return nStr; }}
        public int n { get { return nCol; } }
        public int MaxSum { get { return maxSum; } }

        public MaxSubMatr(int[][] arr)
        {
            original = arr;
        }

        public int[][] getSubMatr()
        {
           
            int[][] newMatrix = new int[nStr][];
            for (int i = 0; i < nStr; i++)
                newMatrix[i] = new int[nCol];

            for (int i = startX, k = 0; i <= endX; i++, k++)
            {
                for (int j = startY, l = 0; j <= endY; j++, l++)
                    newMatrix[k][l] = original[i][j];
            }
            return newMatrix;
        }

        public void maxSubMatrix()
        {
            
            int rowCount = original.Length;
            int columnCount = original[0].Length;

            int[][] matrix = precomputeMatrix(original); //получить матрицу префиксных сумм 

            for (int row1 = 0; row1 < rowCount; row1++)
            {
                for (int row2 = row1; row2 < rowCount; row2++)
                {
                    for (int col1 = 0; col1 < columnCount; col1++)
                    {
                        for (int col2 = col1; col2 < columnCount; col2++)
                        {
                            int computed = computeSum(matrix, row1, row2, col1, col2);
                            if (computed > maxSum || computed == maxSum && (row2 - row1 + 1 < nStr || col2 - col1 + 1 < nCol))
                            {
                                startX = row1; endX = row2;
                                startY = col1; endY = col2;
                                nStr = endX - startX + 1;
                                nCol = endY - startY + 1;
                                maxSum = computed;
                            }
                        }
                    }
                }
            }
        }

        int[][] precomputeMatrix(int[][] matrix)
        {
            int[][] sumMatrix = new int[matrix.Length][];
            for (int i = 0; i < matrix.Length; i++)
            {
                sumMatrix[i] = new int[matrix[0].Length];
            }

            for (int i = 0; i < matrix.Length; i++)
            {
                for (int j = 0; j < matrix[0].Length; j++)
                {
                    if (i == 0 && j == 0)
                    { // первая ячейка
                        sumMatrix[i][j] = matrix[i][j];
                    }
                    else if (j == 0)
                    { // ячейка в первой колонке
                        sumMatrix[i][j] = sumMatrix[i - 1][j] + matrix[i][j];
                    }
                    else if (i == 0)
                    { // ячейка в первом ряду
                        sumMatrix[i][j] = sumMatrix[i][j - 1] + matrix[i][j];
                    }
                    else
                    {
                        sumMatrix[i][j] = sumMatrix[i - 1][j] +
                                          sumMatrix[i][j - 1] -
                                          sumMatrix[i - 1][j - 1] +
                                          matrix[i][j];
                    }
                }
            }
            return sumMatrix;
        }

        int computeSum(int[][] sumMatrix, int i1, int i2, int j1, int j2)
        {
            if (i1 == 0 && j1 == 0)
            { // начинаем с ряда 0, колонки 0
                return sumMatrix[i2][j2];
            }
            else if (i1 == 0)
            { // начинаем с ряда 0
                return sumMatrix[i2][j2] - sumMatrix[i2][j1 - 1];
            }
            else if (j1 == 0)
            { // начинаем с колонки 0
                return sumMatrix[i2][j2] - sumMatrix[i1 - 1][j2];
            }
            else
            {
                return sumMatrix[i2][j2] - sumMatrix[i2][j1 - 1] - sumMatrix[i1 - 1][j2] + sumMatrix[i1 - 1][j1 - 1];
            }
        }

        /*
        private void clearArray(int[] array)
        {
            for (int i = 0; i < array.Length; i++)
                array[i] = 0;
        }

        public void maxSubMatrix()
        {
            int rowCount = original.Length;
            int colCount = original[0].Length;

            int start = 0; //левый столбец ограничивающий подматрицу
            int fin = 0;   //правый

            int[] partialSum = new int[colCount];  // массив сумм подмассива

            // Идем по всем строкам
            for (int rowStart = 0; rowStart < rowCount; rowStart++)
            {
                clearArray(partialSum);

                //  для текущего прямоугольника, ограниченного rowstart и rowend считаем сумму элементов по столбцам
                for (int rowEnd = rowStart; rowEnd < rowCount; rowEnd++)
                {
                    for (int i = 0; i < colCount; i++)
                    {
                        partialSum[i] += original[rowEnd][i];
                    }

                    // ищем координаты столбцов, и считаем сумму
                    int tempMaxSum = findMaxSubArray(partialSum, out start, out fin);

                    if (tempMaxSum > maxSum || 
                        (tempMaxSum == maxSum && (rowEnd - rowStart + 1 < n_str || fin - start + 1 < n_col)))    //выберем подматрицу мин размера с такой суммой
                    {                                                                                            //например, в матрице 0 0
                        startX = rowStart; endX = rowEnd;                                                        //                    2 5     
                        startY = start; endY = fin;                                                              //сама матрица будет иметь сумму 7, но мы выберем подматрицу 2 5       
                        n_str = rowEnd - rowStart + 1;                                                           //тк у нее тоже максимальная сумма, а р-р меньше
                        n_col = fin - start + 1;                                                                 //наверное, это не обязательно...   
                        maxSum = tempMaxSum;
                    }
                }
            }
        }

        private static int findMaxSubArray(int[] arr, out int maxSumStartY, out int maxSumLastY)
        {
            maxSumStartY = 0;
            maxSumLastY = 0;

            int maxSum = arr[0];

            int curSumStartIndex = 0;
            int curSum = arr[0];

            for (int i = 1; i < arr.Length; i++)
            {

                curSum += arr[i];
                if (curSum <= arr[i])
                {
                    curSum = arr[i];
                    curSumStartIndex = i;
                }

                if (curSum > maxSum)
                {
                    maxSumStartY = curSumStartIndex; //начальный столбец подматрицы
                    maxSumLastY = i;                 //конечный столбец подматрицы
                    maxSum = curSum;                 //макс. сумма 
                }
            }
            return maxSum;
        }
        */
    }
}

