// Напишите программу, которая выводит случайное трёхзначное число    
// и удаляет вторую цифру этого числа.

int value = new Random().Next(100, 1000);
System.Console.WriteLine(value);

int[] rez = new int[3];
for (int i = 0; i < 3; i++)
{
    rez[i] = value % 10;
    value = value / 10;
}

System.Console.Write(rez[2]);
System.Console.Write(rez[0]);