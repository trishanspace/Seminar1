﻿// Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

// 2, 3, 7 -> 7
// 44 5 78 -> 78
// 22 3 9 -> 22

int a = int.Parse(Console.ReadLine());
int b = int.Parse(Console.ReadLine());
int c = int.Parse(Console.ReadLine());

if (a > b & a > c)
{
    Console.WriteLine(a);
}
else if (b > a & b > c)
{
    Console.WriteLine(b);
}
else if (c > a & c > b)
{
    Console.WriteLine(c);
}