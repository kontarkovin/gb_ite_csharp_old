/*
Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.

5 -> 2, 4
8 -> 2, 4, 6, 8
*/

Console.WriteLine("Введите число:");
int num = Convert.ToInt32(Console.ReadLine());
Console.Write(num + " -> ");
for (int i = 2; i <= num; i++)
{
    if (i % 2 == 0)
    {
        Console.Write(i);
        if ((i < num) && (i + 1 != num)) Console.Write(", ");
    }
}
Console.WriteLine();