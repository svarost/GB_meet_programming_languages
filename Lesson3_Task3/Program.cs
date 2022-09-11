// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

CubeTable(Prompt("Введите целое число: "));


void CubeTable(int value)
{
    for (int i = 1; i <= value; i++)
    {
        System.Console.Write(Math.Pow(i, 3));
        if (i < value)
        {
            System.Console.Write(", ");
        }
    }
}

// Ввод числа из консоли по приглашению
int Prompt(string message)
{
    System.Console.Write(message); // Вывод приглашения
    string strValue; // Объявление переменной для ввода строки
    strValue = Console.ReadLine() ?? "0"; // Вводим строку с консоли (с консоли можно ввести только строку)
    if (int.TryParse(strValue, out int value) && value > 1)
    {
        return value;
    }
    throw new Exception("Данное значение не соотетствует условию.");
}