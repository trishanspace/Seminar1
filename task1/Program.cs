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
    Console.Write("max= ");
    Console.WriteLine(max = a);

    Console.Write("min= ");
    Console.WriteLine(min = b);
}
else if (a < b)
{
    Console.Write("max= ");
    Console.WriteLine(max = b);

    Console.Write("min= ");
    Console.WriteLine(min = a);
}
else if (a == b)
{
    Console.Write("числа равны");
}