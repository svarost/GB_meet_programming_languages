// Напишите программу, которая принимает на вход цифру, обозначающую день недели,
// и проверяет, является ли этот день выходным.

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

int value = Prompt("Введите номер дня недели: ");
if (value < 1 | value > 7)
{
    System.Console.WriteLine("День недели с таким номером не существует.");
}
else
{
    if (value > 5) System.Console.WriteLine($"{value} - выходной день.");
    else System.Console.WriteLine($"{value} - невыходной день.");
}