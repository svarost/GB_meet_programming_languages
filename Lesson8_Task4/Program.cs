// Напишите программу, которая заполнит спирально квадратный массив

//Main
PrintArray(GenerateArray(4, 1, 10));


// Methods
void PrintArray(int[,] array)
{
    Console.WriteLine("\n");
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j]}\t");
        }
        Console.WriteLine("\n");
    }
}

int[,] GenerateArray(int length, int minRange, int maxRange)
{
    int[,] array = new int[length, length];
    int index = 0;
    int count = 1;
    
    while (length > 0)
    {
        // fill top row
        for (int i = index; i < length; i++)
        {
            array[index, i] = count;
            count++;
        }

        //fill right column
        for (int i = index + 1; i < length; i++)
        {
            array[i, length - 1] = count;
            count++;
        }
        length--;

        //fill footer row
        for (int i = length - 1; i >= index; i--)
        {
            array[length, i] = count;
            count++;
        }
        
        //fil left collumn
        for (int i = length - 1; i > index; i--)
        {
            array[i, index] = count;
            count++;
        }
        index++;
    }
    
    return array;
}