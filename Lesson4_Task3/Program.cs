// Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.

System.Console.WriteLine(SumDigitsOfNumber(Prompt("Введите массив из 8 элементов: ")));


// Создание массива
int[] CreatArray(string String)
{   
    пше


    return array;
}

// Ввод числа из консоли по приглашению
int Prompt(string message)
{
    System.Console.Write(message); // Вывод приглашения
    // string strValue; // Объявление переменной для ввода строки
    // strValue = Console.ReadLine(); // Вводим строку с консоли (с консоли можно ввести только строку)
    if (int.TryParse(Console.ReadLine(), out int value))
    {
        return value;
    }
    throw new Exception("Данное значение невозможно преобразовать в число");
}