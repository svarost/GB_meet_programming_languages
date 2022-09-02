// Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

// Ввод числа из консоли по приглашению
int Prompt(string message)
{
    System.Console.Write(message); // Вывод приглашения
    string strValue; // Объявление переменной для ввода строки
    strValue = Console.ReadLine() ?? "0"; // Вводим строку с консоли (с консоли можно ввести только строку)
    int value = int.Parse(strValue); // Преобразование строки в целое число
    return value;
}

int value1 = Prompt("Введите первое число: ");
int value2 = Prompt("Введите второе число: ");
int value3 = Prompt("Введите третье число: ");
int max = value1;

if (value2 > max)
{
    max = value2;
}
if (value3 > max)
{
    max = value3;
}

Console.Write($"Max = {max}");