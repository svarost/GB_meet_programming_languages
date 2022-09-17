// Пользователь вводит с клавиатуры M чисел. Посчитайте,
// сколько чисел больше 0 ввёл пользователь.


int[] arr = Prompt("Введите числа: ");
PrintArray(arr);
Console.WriteLine($" --> {PositiveNumberCount(arr)}");


int [] Prompt(string message)
{
    char [] separators = new char [] {',', ' '};
    
    System.Console.Write(message); // Вывод приглашения
    string? value = Console.ReadLine();
    if (!String.IsNullOrEmpty(value))
    {
        string [] stringArray = value.Split(separators, StringSplitOptions.RemoveEmptyEntries);
        int [] intArray = new int [stringArray.Length];
        for (int i = 0; i < stringArray.Length; i++)
        {
            if (int.TryParse(stringArray[i], out int num))
            {
                intArray[i] = num;
            }
            else throw new Exception("Не все элементы введенной последовательности являются числами.");
        }
        return intArray;
    }
    throw new Exception("Введен пустой массив.");
}

int PositiveNumberCount(int [] array)
{
    int sum = 0;
    foreach (var item in array)
    {
        if (item > 0) sum++;
    }
    return sum;
}

void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        System.Console.Write(array[i]);
        if (i < array.Length - 1) System.Console.Write(", ");
    }
}