// Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

System.Console.WriteLine(SumDigitsOfNumber(Prompt("Введите число: ")));


// Возведение в степень
int SumDigitsOfNumber(int number)
{   
    int count = Math.Abs(number).ToString().Length;
    int sum = 0;
    for(int i = 0; i < count; i++)
    {
        sum += Math.Abs(number) % 10;
        number /= 10;
    }
    return sum;
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