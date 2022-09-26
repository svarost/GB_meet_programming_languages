// Задайте прямоугольный двумерный массив. Напишите программу, 
// которая будет находить строку с наименьшей суммой элементов.

//Main
int[,] array = GenerateArray(4, 4, 1, 10);
PrintMultiArray(array);
Console.WriteLine();
PrintRowMultiArray(array, IndexRowMinSum(array));


// Methods
void PrintMultiArray(int[,] array)
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

void PrintRowMultiArray(int[,] array, int indexRow)
{
    for (int i = 0; i < array.GetLength(1); i++)
        {
            Console.Write($"{array[indexRow, i]}\t");
        }
        Console.WriteLine();
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

int IndexRowMinSum(int[,] array)
{
    int minSum = 0;
        for (int i = 0; i < array.GetLength(1); i++)
        {
            minSum += array[0, i];
        }

    int index = 0;
    for (int i = 1; i < array.GetLength(0); i++)
    {        
        int sum = 0;
        for (int j = 0; j < array.GetLength(1); j++)
        {
            sum += array[i, j];
        }
        if (minSum > sum) index = i;
    }
    return index;
}