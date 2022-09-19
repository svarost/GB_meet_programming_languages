// Задайте двумерный массив размером m×n,
// заполненный случайными вещественными числами.

//Main
int[,] matrix = GenerateMatrix(4);
PrintMatrix(matrix);
var minSum = SumItemArray(MinColumnValue(matrix));
var maxSum = SumItemArray(MaxRowValue(matrix));
Console.WriteLine(maxSum);
Console.WriteLine(minSum);
Console.WriteLine(maxSum - minSum);

// Methods
int[,] GenerateMatrix(int rowCount, int columnCount)
{
    int[,] matrix = new int[rowCount, columnCount];
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
           // matrix[i, j] = new Random().NextDouble(1, 10); функц генератор вещ. чисел
           // return min + r.NextDouble() * (max - min);
        }
    }
    return matrix;
}

void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i, j]}  ");
        }
        Console.WriteLine();
    }
}

int[] MaxRowValue (int[,] matrix)
{
    int[] maxRowValue = new int[matrix.GetLength(0)];
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        int maxValue = matrix[i, 0];
        for (int j = 1; j < matrix.GetLength(1); j++)
        {
            if (maxValue < matrix[i, j])
            {
                maxValue = matrix[i, j];
            }
        }
        maxRowValue[i] = maxValue;
    }
    return maxRowValue;
}

int[] MinColumnValue (int[,] matrix)
{
    int[] minColumnValue = new int[matrix.GetLength(0)];
    for (int i = 0; i < matrix.GetLength(1); i++)
    {
        int minValue = matrix[0, i];
        for (int j = 1; j < matrix.GetLength(0); j++)
        {
            if (minValue > matrix[j, i])
            {
                minValue = matrix[j, i];
            }
        }
        minColumnValue[i] = minValue;
    }
    return minColumnValue;
}

int SumItemArray(int[] array)
{
    int sum = 0;
    foreach (var item in array)
    {
        sum += item;
    }
    return sum;
}