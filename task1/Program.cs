// int N = int.Parse(Console.ReadLine());

// // int Nmin = -N;

// // while (N>=Nmin)
// // {
// // Console.WriteLine();
// // N = N-1;
// // }
// // Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

// // a = 5; b = 7 -> max = 7
// // a = 2 b = 10 -> max = 10
// // a = -9 b = -3 -> max = -3

int a = int.Parse(Console.ReadLine());
int b = int.Parse(Console.ReadLine());

int max = a;
int min = b;

if (a > b)
{
    Console.WriteLine();
    int max = a;
    int min = b;
}
else
{
    Console.WriteLine();
    int max = b;
    int min = a;
}

Console.Write("max= ");
Console.WriteLine(max);

Console.Write("min= ");
Console.WriteLine(min);