using System;

Console.Write("Введи N: ");
int N = Convert.ToInt16(Console.ReadLine());
Console.Write("Введи M: ");
int M = Convert.ToInt16(Console.ReadLine());
Console.WriteLine($"N={N}, M={M}");
int sum = 0;
if (M>N)
{   
    for (int i = N; i <= M; i++)
    {
        Console.Write($" {i}");
        sum += i;
    }
}
else
{
    for (int i = M; i <= N; i++)
    {
        Console.Write($" {i}");
        sum +=i;
    }
}
Console.WriteLine($"");
Console.WriteLine($"Сумма чисел равна  {sum}");