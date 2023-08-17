/*
Напишите программу, которая принимает на вход два числа и проверяет, является ли одно число квадратом другого.

5, 25 -> да
-4, 16 -> да
25, 5 -> да
8, 9 -> нет
*/

string answer = "нет";
Console.WriteLine("Введите число 1:");
int numberOne = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите число 2:");
int numberTwo = Convert.ToInt32(Console.ReadLine());

if (numberOne == numberTwo * numberTwo || numberTwo == numberOne * numberOne)
{
    answer = "да";
}
Console.WriteLine($"{numberOne}, {numberTwo} -> {answer}");
