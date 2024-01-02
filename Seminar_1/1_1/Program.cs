﻿// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");

//Напишите программу, которая на вход
//принимает два целых числа и проверяет,
//является ли первое число квадратом второго.
//a = 25, b = 5 => да
//a = 2, b = 10 => нет


Console.Write("Enter a number 1: ");

// int b1 = Convert.ToInt32(Console.ReadLine()!); - ниже другой тип преобразования данного
int b1 = int.Parse(Console.ReadLine()!);

Console.Write("Enter a number 2: ");

// int b2 = Convert.ToInt32(Console.ReadLine()!); - ниже другой тип преобразования данного
int b2 = int.Parse(Console.ReadLine()!);

if (b1 == b2 * b2)
    Console.WriteLine("Yes");
else
    Console.WriteLine("No");
