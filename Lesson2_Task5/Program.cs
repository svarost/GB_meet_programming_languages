// Напишите программу, которая генерирует несколько случайных чисел,  
// и в цикле проверяет, кратны ли эти числа предварительно введенному числу,
// при кратности - цикл прерывается.
// Введенное число 2.

int[] numbers = new int[5];
for (int i = 0; i < 5; i++)
{
    numbers[i] = new Random().Next(0, 100);
}

for (int i = 0; i < numbers.Length; i++)
{
    if (numbers[i] % 2 == 0)
    {
        System.Console.WriteLine($"{numbers[i]} -> да");
        break;
    }     
    else System.Console.WriteLine($"{numbers[i]} -> нет");
}