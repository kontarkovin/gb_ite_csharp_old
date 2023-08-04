/*
Напишите программу, которая на вход принимает два числа и проверяет, является ли первое квадратом второго

a = 25, b = 5 -> Да
a = 2, b = 10 -> Нет
а = 9, b =-3 -> Да
a = -3, b = 9 -> Нет
*/

Console.WriteLine("Введите число 'a':");
int number1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число 'b':");
int number2 = Convert.ToInt32(Console.ReadLine());
Console.Write("a = " + number1 + ", b = " + number2);
if (number1 == number2 * number2)
{
   Console.WriteLine (" -> Да");
}
else
{
    Console.WriteLine(" -> Нет");
}