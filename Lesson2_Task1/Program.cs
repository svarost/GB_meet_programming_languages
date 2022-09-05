// Напишите программу, которая принимает на вход трёхзначное число   
// и на выходе показывает вторую цифру этого числа.

// Ввод числа из консоли по приглашению
int Prompt(string message)
{
    System.Console.Write(message); // Вывод приглашения
    string strValue; // Объявление переменной для ввода строки
    strValue = Console.ReadLine() ?? "0"; // Вводим строку с консоли (с консоли можно ввести только строку)
    int value = int.Parse(strValue); // Преобразование строки в целое число
    return value;
}

int value = 0;
while (value < 100 | value > 999 ) {
    value = Prompt("Введите трехзначное число: ");
}

int [] rez = new int[3];
for (int i = 0; i < 2; i++) {
    rez[i] = value % 10;
    value = value / 10;
}
System.Console.WriteLine(rez[1]);
