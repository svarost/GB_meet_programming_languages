// Найдите максимальное значение в матрице по каждой строке,
// получите сумму этих максимумов. Затем найдите минимальное 
// значение по каждой колонке,получите сумму этих минимумов. 
// Затем из первой суммы (с максимумами) вычтите вторую сумму(с минимумами)

//Main
int[,] matrix = GenerateMatrix(4);
PrintMatrix(matrix);
Console.WriteLine(SumItemArray(MaxRowValue(matrix)));
Console.WriteLine(SumItemArray(MinColumnValue(matrix)));
Console.WriteLine(SumItemArray(MaxRowValue(matrix)) 
                - SumItemArray(MinColumnValue(matrix)));

// Methods
int[,] GenerateMatrix(int size)
{
    int[,] matrix = new int[size, size];
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = new Random().Next(1, 10);
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