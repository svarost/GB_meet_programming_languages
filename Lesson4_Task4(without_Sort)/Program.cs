// Напишите программу, которая задаёт массив из 8 элементов случайными числами и выводит их на экран.
// Также ищет второй максимум (число меньше максимального элемента, но больше всех остальных).

int[] arr = GenArray(8);
PrintArray(arr);
System.Console.Write($" -> {MaxTwo(arr)}");


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

int MaxTwo(int[] array)
{
    int iMax = 0;
    int iMaxTwo = 1;
    for (int i = 1; i < array.Length; i++)
    {
        if (array[i] > array[iMax])
        {
            iMaxTwo = iMax;
            iMax = i;
        }
        else if (array[i] > array[iMaxTwo] && array[i] != array[iMax]) iMaxTwo = i;
    }
    return array[iMaxTwo];
}