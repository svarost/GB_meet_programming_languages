﻿// Напишите программу, которая задаёт массив из 8 элементов случайными числами и выводит их на экран.
// Также ищет второй максимум (число меньше максимального элемента, но больше всех остальных).

int[] arr = GenArray(8);
PrintArray(arr);
System.Console.Write(" -> ");
PrintNumberMaxValueArray(arr, 2);


int[] GenArray(int size)
{
    int[] intArr = new int[size];

    for (int i = 0; i < size; i++)
    {
        intArr[i] = new Random().Next(0, 10);
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

int[] SortArray(int[] array)
{
    int indx;
    for (int i = 0; i < array.Length; i++)
    {
        indx = i;
        for (int j = i; j < array.Length; j++)
        {
            if (array[j] < array[indx])
            {
                indx = j;
            }
        }

        if (array[indx] == array[i]) continue;
        int temp = array[i];
        array[i] = array[indx];
        array[indx] = temp;
    }
    return array;
}

void PrintNumberMaxValueArray(int[] array, int number)
{
    System.Console.Write($"{SortArray(array)[array.Length - number]}");
}