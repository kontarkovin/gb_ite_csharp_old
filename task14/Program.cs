/*
Напишите программу, которая принимает на вход число и проверяет, кратно ли оно одновременно 7 и 23

14 -> нет
46 -> нет
161 -> да
*/

string message = "нет";
int numberOne = 7;
int numberTwo = 23;
Console.WriteLine("Введите число:");
int number = Convert.ToInt32(Console.ReadLine());

if (number % (numberOne * numberTwo) == 0) message = "да";
Console.WriteLine($"{number} -> {message}");