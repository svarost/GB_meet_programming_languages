// Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

System.Console.WriteLine(Exponentiation(Prompt("Введите число: "), Prompt("Введите степень: ")));


// Возведение в степень
int Exponentiation(int num, int degree)
{   
    if (degree < 0)
    {
        throw new Exception("Введено значение степени в ненатуральном виде.");
    }
    if (degree == 0) return 1;
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
    System.Console.Write(message);
    string strValue;
    strValue = Console.ReadLine() ?? "0";
    if (int.TryParse(strValue, out int value))
    {
        return value;
    }
    throw new Exception("Данное значение невозможно преобразовать в число");
}