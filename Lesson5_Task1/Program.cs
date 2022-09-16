// Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу,
// которая покажет количество чётных чисел в массиве.

int[] arr = GenArray();
PrintArray(arr);
System.Console.Write($" -> {EvenCount(arr)}");


int[] GenArray()
{
    int size = new Random().Next(2, 10);
    int[] intArr = new int[size];

    for (int i = 0; i < size; i++)
    {
        intArr[i] = new Random().Next(100, 1000);
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

int EvenCount(int[] array)
{
    int count = 0;
    foreach (var item in array)
    {
        if (item % 2 == 0) count++;
    }
    return count;
}