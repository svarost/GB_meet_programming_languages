// Напишите программу, которая найдёт точку пересечения двух прямых,
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2;
// значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

double [] directAB = Prompt("AB");
double [] directCD = Prompt("CD");
IntersectionDirects(directAB, directCD);


bool IsParallel(double[] directAB, double[] directCD)
{
    return (directAB[0] * directCD[1] - directAB[1] * directCD[0]) == 0;
}

double FindX(double[] directAB, double[] directCD)
{
    return (directCD[1] - directAB[1]) / (directAB[0] - directCD[0]);
}

double FindY(double[] directAB, double[] directCD)
{
    return directAB[0] * (directCD[1] - directAB[1])
           / (directAB[0] - directCD[0]) + directAB[1];
}

string PrintDirect(double[] direct)
{
    string s = ("y = " + direct[0] + "x + " + direct[1]);
    return s;
}

void IntersectionDirects(double[] directAB, double[] directCD)
{
    if (IsParallel(directAB, directCD))
    {
        Console.WriteLine("Прямые параллельны и не имеют точек пересечения.");
        return;
    }

    Console.WriteLine($"Прямые ({PrintDirect(directAB)})" 
                    + $" и ({PrintDirect(directCD)}) пересекаются в точке "
                    + $"({FindX(directAB, directCD):f2}; {FindY(directAB, directCD):f2}).");
}

double[] Prompt(string message)
{
    double[] direct = new double[2];
    double value;
    string[] calls = new string[] 
            {"Введите угловой коэффициент прямой " + message + " (k): ", 
             "Введите точку пересечения прямой " + message + " с осью y (b): "};
    
    for (int i = 0; i < 2; i++)
    {
        Console.Write(calls[i]);
        
        if (double.TryParse(Console.ReadLine(), out value))
        {
            direct[i] = value;
        }
        else throw new Exception("Введено недопустимое значение.");
    }
    return direct;
}