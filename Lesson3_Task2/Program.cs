// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

const int X = 0;
const int Y = 1;
const int Z = 2;

int[] aPoint = InsetrtCoords("A");
int[] bPoint = InsetrtCoords("B");
System.Console.WriteLine($"Расстояние между точками = {Length(aPoint, bPoint):f2}");


int Promt(string message)
{
    System.Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}

int[] InsetrtCoords(string point)
{
    int[] temp = new int[3];
    temp[X] = Promt($"Введите X точки {point}: ");
    temp[Y] = Promt($"Введите Y точки {point}: ");
    temp[Z] = Promt($"Введите Z точки {point}: ");
    
    return temp;
}

double Length(int[] firstPoint, int[] secondPoint)
{
    return Math.Sqrt(Math.Pow(firstPoint[X] - secondPoint[X], 2) 
        + Math.Pow(firstPoint[Y] - secondPoint[Y], 2) 
        + Math.Pow(firstPoint[Z] - secondPoint[Z], 2));
}