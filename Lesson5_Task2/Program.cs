// Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов,
// стоящих на нечётных позициях.

int[] arr = GenArray();
PrintArray(arr);
System.Console.Write($" -> {OrderItemsArraySum(arr, 1)}");


int[] GenArray()
{
    int size = new Random().Next(2, 9);
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

int OrderItemsArraySum(int[] array, int order)
{
    int sum = 0;
    for (int i = order; i < array.Length; i += 2)
    {
        sum += array[i];
    }
    return sum;
}