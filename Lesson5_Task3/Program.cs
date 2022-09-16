// Задайте массив вещественных чисел. Найдите разницу между
// максимальным и минимальным элементов массива.

int[] arr = GenArray();
PrintArray(arr);
System.Console.Write($" -> {MaxArrayItem(arr) - MinArrayItem(arr)}");


int[] GenArray()
{
    int size = new Random().Next(2, 9);
    int[] intArr = new int[size];

    for (int i = 0; i < size; i++)
    {
        intArr[i] = new Random().Next(1, 100);
    }
    return intArr;
}

void PrintArray(int[] array)
{
    System.Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        System.Console.Write(array[i]);
        if (i < array.Length - 1) System.Console.Write(", ");
    }
    System.Console.Write("]");
}

int MaxArrayItem(int[] array)
{
    int max = array[0];
    for (int i = 1; i < array.Length; i++)
    {
        if (array[i] > max) max = array[i];
    }
    // System.Console.WriteLine($"max = {max}");
    return max;
}

int MinArrayItem(int[] array)
{
    int min = array[0];
    for (int i = 1; i < array.Length; i++)
    {
        if (array[i] < min) min = array[i];
    }
    // System.Console.WriteLine($"min = {min}");
    return min;
}