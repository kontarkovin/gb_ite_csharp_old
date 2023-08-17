/*
Напишите программ, котороя будет принимать на вход два числа и выводить, является ли второе число кратным первому.
Если второе число некратно первому, то программа выводит остаток от деления.

34, 5 -> некратно, остаток 4
16, 4 -> кратно
*/

Console.WriteLine("Введите число 1:");
int numberOne = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите число 2:");
int numberTwo = Convert.ToInt32(Console.ReadLine());

string message = "некратно, остаток ";
int remainder = numberOne % numberTwo;
if (remainder == 0) message = "кратно";
else message = message + remainder.ToString();
Console.WriteLine($"{numberOne}, {numberTwo} -> {message}");