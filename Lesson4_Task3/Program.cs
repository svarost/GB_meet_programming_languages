// Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.

PrintArray(Prompt("Введите массив из 8 элементов: "));


// Ввод числа из консоли по приглашению
int [] Prompt(string message)
{
    char [] separators = new char [] {',', ' '};
    
    System.Console.Write(message); // Вывод приглашения
    string? value = Console.ReadLine();
    if (value != null)
    {
        string [] stringArray = value.Split(separators, StringSplitOptions.RemoveEmptyEntries);
        int [] intArray = new int [stringArray.Length];
        for (int i = 0; i < stringArray.Length; i++)
        {
            if (int.TryParse(stringArray[i], out int num))
            {
                intArray[i] = num;
            }
            else throw new Exception("Введенные значения невозможно преобразовать в числовой массив.");
        }
        return intArray;
    }
    throw new Exception("Введен пустой массив.");
}

void PrintArray(int [] array)
{
    System.Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        System.Console.Write(array[i]);
        if (i < array.Length - 1) System.Console.Write(", ");
    }
    System.Console.Write("]");
}