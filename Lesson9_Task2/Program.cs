// Задайте значения M и N. Напишите программу, которая найдёт
// сумму натуральных элементов в промежутке от M до N.

//Main
int mValue = Promt("Введите натуральное чило M: ");
int nValue = Promt("Введите натуральное чило N: ");
Console.WriteLine($"M = {mValue}; N = {nValue} -> {SumNumbers(mValue, nValue)}");


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

int SumNumbers(int mValue, int nValue)
{
    return mValue < nValue ? mValue + SumNumbers(mValue + 1, nValue) : nValue;
}