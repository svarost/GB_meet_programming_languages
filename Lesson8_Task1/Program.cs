// Задайте двумерный массив. Напишите программу, которая упорядочит
// по убыванию элементы каждой строки двумерного массива.

//Main
int[,] array = GenerateArray(4, 4, 1, 10);
PrintArray(array);
System.Console.WriteLine();
PrintArray(SortArray(array));


// Methods
void PrintArray(int[,] array)
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

int[,] GenerateArray(int rowLength, int columnLength, int minRange, int maxRange)
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

int[,] SortArray(int[,] array)
{
    // int[,] resArr = new int[array.GetLength(0), array.GetLength(1)];
    for (int k = 0; k < array.GetLength(0); k++)
    {
        for (int i = 0; i < array.GetLength(1) - 1; i++)
        {
            for (int j = 1; j < array.GetLength(1); j++)
            {
                if (array[k, i] < array[k, j])
                {
                    int temp = array[k, i];
                    array[k, i] = array[k, j];
                    array[k, j] = temp;
                }            
            }
        }
    }
    return array;
}