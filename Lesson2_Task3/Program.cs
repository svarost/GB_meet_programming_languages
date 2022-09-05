// Напишите программу, которая выводит третью цифру заданного числа     
// или сообщает, что третьей цифры нет.

// Ввод числа из консоли по приглашению
int Prompt(string message)
{
    System.Console.Write(message); // Вывод приглашения
    string strValue; // Объявление переменной для ввода строки
    strValue = Console.ReadLine() ?? "0"; // Вводим строку с консоли (с консоли можно ввести только строку)
    bool isNumber = int.TryParse(strValue, out int value);
    if (isNumber)
    {
        return value;
    }
    throw new Exception("Данное значение невозможно преобразовать в число");
}

int value = Prompt("Введите число: ");
if (value < 100)
{
    System.Console.WriteLine("Третья цифра в заданном числе отсутствует.");
} else 
{
    int [] rez = new int[3];
    for (int i = 0; i < 3; i++) {
        rez[i] = value % 10;
        value = value / 10;
    }

    System.Console.WriteLine(rez[2]);
}