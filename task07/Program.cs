/*
Напишите программу, которая на входе принимает трёхзначное число и на выходе показывает последнюю цифру этого числа
*/

Console.WriteLine("Введите число:");
int num = Convert.ToInt32(Console.ReadLine());
if (num < 0)
{
    num = -num;
}
if ((100 <= num) && (num <= 999))
{
    Console.WriteLine("Последняя цифра числа: " + num % 10);
}
else
{
    Console.WriteLine("Число не является трёхзначным!");
}
