// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

// Ввод числа из консоли по приглашению
int Prompt(string message)
{
    System.Console.Write(message); // Вывод приглашения
    string strValue; // Объявление переменной для ввода строки
    strValue = Console.ReadLine() ?? "0"; // Вводим строку с консоли (с консоли можно ввести только строку)
    if (int.TryParse(strValue, out int value))
    {
        return value;
    }
    throw new Exception("Данное значение невозможно преобразовать в число");
}

// Проверка на палиндром
bool IsPalindrome(string value)
{
    bool rez = true;
    for (int i = 0; i < value.Length / 2; i++)
    {
        if (value[i] != value[value.Length - 1 - i])
        {
            rez = false;
            break;
        }
    }
    return rez;
}

int value = Prompt("Введите пятизначное число: ");
if (value < 9999 | value > 99999) // Проверка на пятизночность
{
    System.Console.WriteLine("Введено непятизначное число.");
}
else
{
    if (IsPalindrome(value.ToString()))
    {
        System.Console.WriteLine($"{value} -> да.");
    }
    else
    {
        System.Console.WriteLine($"{value} -> нет.");
    }
}