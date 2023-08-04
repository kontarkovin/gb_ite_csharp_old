/*
Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным
(делится ли оно на два без остатка)

4 -> ДА
-3 -> НЕТ
7 -> НЕТ
*/

Console.WriteLine("");
Console.WriteLine("*** ПРОВЕРЯЕТ, ЯВЛЯЕТСЯ ЛИ ЧИСЛО ЧЁТНЫМ ***");
Console.WriteLine("Введите число:");
int number = Convert.ToInt32(Console.ReadLine());
Console.Write(number + " -> ");
if (number % 2 == 0)
{
    Console.WriteLine("ДА");
}
else
{
    Console.WriteLine("НЕТ");
}