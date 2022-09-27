// Задайте значение N. Напишите программу, которая выведет 
// все натуральные числа в промежутке от N до 1.
// Выполнить с помощью рекурсии.

//Main
int value = Promt("Введите натуральное чило N: ");
Console.WriteLine($"N = {value} -> \"{NumbersRec(value)}\"");


// Methods
int Promt(string message)
{
    Console.Write(message);
    if (int.TryParse(Console.ReadLine(), out int value))
    {
        return value;
    }
    throw new Exception("Введено некорректное значение");
}

string NumbersRec(int value)
{
    if (value > 1) return $"{value}, " + NumbersRec(value - 1);
    else return "1";
}