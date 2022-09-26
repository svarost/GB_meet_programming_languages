// Задайте две матрицы. Напишите программу,
// которая будет находить произведение двух матриц.

//Main
int[,] matrixA = GenerateMAtrix(3, 4, 1, 10);
PrintMatrix(matrixA);
Console.WriteLine();
int[,] matrixB = GenerateMAtrix(4, 2, 1, 10);
PrintMatrix(matrixB);
Console.WriteLine();
if (IsCompatible(matrixA, matrixB))
{
    PrintMatrix(MatrixsMultiply(matrixA, matrixB));
}
else Console.WriteLine("Матрицы несовместимы.");



// Methods
void PrintMatrix(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j]}\t");
        }
        Console.WriteLine();
    }
}

int[,] GenerateMAtrix(int rowLength, int columnLength, int minRange, int maxRange)
{
    int[,] array = new int[rowLength, columnLength];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(minRange, maxRange);
        }
    }
    return array;
}

bool IsCompatible(int[,] matrixA, int[,] matrixB)
{
    return matrixA.GetLength(1) == matrixB.GetLength(0);
}

int[,] MatrixsMultiply(int[,] matrixA, int[,] matrixB)
{
    int[,] resArray = new int[matrixA.GetLength(0), matrixB.GetLength(1)];

    for (int i = 0; i < resArray.GetLength(0); i++)
    {
        for (int j = 0; j < resArray.GetLength(1); j++)
        {
            int temp = 0;
            for (int k = 0; k < matrixA.GetLength(1); k++)
            {
                temp += matrixA[i, k] * matrixB[k, j];
            }
            resArray[i, j] = temp;
        }
    }
    return resArray;
}