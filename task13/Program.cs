/*
Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

645 -> 5
78 -> третьей цифры нет
32679 -> 6
*/

string numberThreeStr = "третьей цифры нет";
int number = new Random().Next(100000);

if (number > 99)
{
    numberThreeStr = number.ToString()[2].ToString();
}
Console.WriteLine($"{number} -> {numberThreeStr}");