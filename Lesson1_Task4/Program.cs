// Напишите программу, которая на вход принимает число (N),  
// а на выходе показывает все чётные числа от 1 до N.

// Ввод числа из консоли по приглашению
int Prompt(string message)
{
    System.Console.Write(message); // Вывод приглашения
    string strValue; // Объявление переменной для ввода строки
    strValue = Console.ReadLine() ?? "0"; // Вводим строку с консоли (с консоли можно ввести только строку)
    int value = int.Parse(strValue); // Преобразование строки в целое число
    return value;
}

int value = Prompt("Введите число: ");
int i = 2;

while (i <= value) {
    System.Console.Write(i);
    i += 2;
    if (i <= value) System.Console.Write(", ");
}