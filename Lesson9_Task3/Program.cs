// Напишите программу вычисления функции Аккермана 
// с помощью рекурсии. Даны два неотрицательных числа m и n.

//Main
int mValue = Promt("Введите натуральное чило m: ");
int nValue = Promt("Введите натуральное чило n: ");
Console.WriteLine($"m = {mValue}, n = {nValue} -> A(m, n) = {AkkermanFunction(mValue, nValue)}");


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

double AkkermanFunction(int mValue, int nValue)
{
    
    if (mValue == 0) return Convert.ToDouble(nValue + 1);
    if (mValue > 0 && nValue == 0) 
        {return Convert.ToDouble(AkkermanFunction(mValue - 1, 1));}
    return Convert.ToDouble(AkkermanFunction(mValue - 1, 
            Convert.ToInt32(AkkermanFunction(mValue, nValue - 1))));
}