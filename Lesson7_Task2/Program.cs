//  Напишите программу, которая на вход принимает позиции элемента 
// в двумерном массиве, и возвращает значение этого элемента или же указание, 
// что такого элемента нет.


//Main
int[,] matrix =
        GenerateMatrix(4, 4, 1, 10);
int row = Prompt("Введите номер строки массива: ");
int col = Prompt("Введите номер столбца массива: ");
PrintMatrix(matrix);
Console.WriteLine(IsEntry(matrix, row, col) ? $"({row}, {col}) -> " + matrix[row, col] 
                        : "Такого числа в массиве нет.");


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

int Prompt(string message)
{
    Console.Write(message); // Вывод приглашения
    if (int.TryParse(Console.ReadLine(), out int value) && value > 0)
        {
            return value;
        }
    throw new Exception("Введено некорректное значение.");
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

bool IsEntry(int[,] matrix, int row, int column)
{
    return (row < matrix.GetLength(0) && column < matrix.GetLength(1));
}