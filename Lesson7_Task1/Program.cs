// Задайте двумерный массив размером m×n,
// заполненный случайными вещественными числами.

//Main
double[,] matrix = 
        GenerateMatrix(Promt("Введите количество строк в массиве: "),
        Promt("Введите количество столбцов в массиве: "));
PrintMatrix(matrix);


// Methods
double[,] GenerateMatrix(int rowCount, int columnCount)
{
    double[,] matrix = new double[rowCount, columnCount];
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
           matrix[i, j] = GenerateDouble(-20, 20);
        }
    }
    return matrix;
}

void PrintMatrix(double[,] matrix)
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

double GenerateDouble(double min, double max)
{
    return Math.Round((min + new Random().NextDouble() * (max - min)), 2);
}

int Promt(string message)
{
    Console.Write(message);
    if(int.TryParse(Console.ReadLine(), out int value) && value != 0)
    {
        return value;
    }
    throw new Exception("Введенное значение невозможно преобразовать в натуральное число.");
}