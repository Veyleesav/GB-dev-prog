﻿// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
//456 -> 5
//782 -> 8
//918 -> 1

Console.WriteLine("Enter a three-digit number:");
int inpNum = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"{(inpNum%100)/10}");
