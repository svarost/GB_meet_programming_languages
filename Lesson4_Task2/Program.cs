// Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

System.Console.WriteLine(SumDigitsOfNumber(Prompt("Введите число: ")));


// Возведение в степень
int SumDigitsOfNumber(int number)
{   
    int numAbs = Math.Abs(number);
    int sum = 0;
    while (numAbs > 10)
    {
        sum += numAbs % 10;
        numAbs /= 10;
    }
    sum += numAbs;
    return sum;
}

// Ввод числа из консоли по приглашению
int Prompt(string message)
{
    System.Console.Write(message);
    if (int.TryParse(Console.ReadLine(), out int value))
    {
        return value;
    }
    throw new Exception("Данное значение невозможно преобразовать в число");
}