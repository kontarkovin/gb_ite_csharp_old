﻿/*
Напишите программу, которая выводит случайное трёхзначное число и удаляет вторую цифру этого числа.

456 -> 46
782 -> 72
918 -> 98
*/

int number = new Random().Next(100, 1000);
int numberOne = number / 100;
int numberThree = number % 10;

int result = numberOne * 10 + numberThree;
Console.WriteLine($"{number} -> {result}");