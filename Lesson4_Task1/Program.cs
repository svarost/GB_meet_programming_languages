// Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

System.Console.WriteLine(Exponentiation(Prompt("Введите число: "), Prompt("Введите степень: ")));


// Возведение в степень
int Exponentiation(int num, int degree)
{   
    int pow = num;
    for(int i = 1; i < degree; i++)
    {
        pow *= num;
    }
    return pow;
}

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