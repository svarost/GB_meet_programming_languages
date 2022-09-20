// Задайте двумерный массив из целых чисел.
// Найдите среднее арифметическое элементов в каждом столбце.

//Main
int[,] matrix = GenerateMatrix(4, 4, 1, 10);
PrintMatrix(matrix);
PrintResalt(ArithmeticMean(matrix));


// Methods
void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i, j]}\t");
        }
        Console.WriteLine();
    }
}

int[,] GenerateMatrix(int rowLength, int columnLength, int minRange, int maxRange)
{
    int[,] matrix = new int[rowLength, columnLength];
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = new Random().Next(minRange, maxRange);
        }
    }
    return matrix;
}

double[] ArithmeticMean(int[,] array)
{
    double[] arithmeticMeans = new double[array.GetLength(0)];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        double sum = 0;
        for (int j = 0; j < array.GetLength(1); j++)
        {
            sum += array[i, j];
        }
        arithmeticMeans[i] = sum / array.GetLength(1);
    }
    return arithmeticMeans;
}

void PrintResalt(double[] array)
{
    Console.Write("Среднее арифметическое каждого столбца: ");
    for (var i = 0; i < array.Length; i++)
    {
        Console.WriteLine((i < array.Length - 1) ? 
            $"{array[i]}; " : $"{array[i]}.");
    }
}