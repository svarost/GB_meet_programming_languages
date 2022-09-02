// Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

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

if (value1 > value2)
{
    System.Console.WriteLine($"Max = {value1}");
    System.Console.WriteLine($"Min = {value2}");

}
else
{
    System.Console.WriteLine($"Max = {value2}");
    System.Console.WriteLine($"Max = {value1}");
}

