/*
Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

6 -> да
7 -> да
1 -> нет
*/

string answer = "нет";
//int weekDay = new Random().Next(1, 8);
Console.WriteLine("*** ПРОВЕРЯЕТ, ЯВЛЯЕТСЯ ЛИ ДЕНЬ НЕДЕЛИ ВЫХОДНЫМ ***");
Console.WriteLine("Введите номер дня недели:");
int weekDay = Convert.ToInt32(Console.ReadLine());

if (weekDay < 1 || weekDay > 7) answer = "не является днём недели";
if (weekDay == 6 | weekDay == 7) answer = "да";
Console.WriteLine($"{weekDay} -> {answer}");