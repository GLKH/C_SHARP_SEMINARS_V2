﻿//Напишите программу, которая принимает на вход
//трёхзначное целое число и на выходе показывает сумму
//первой и последней цифры этого числа.
//456 => 10
//782 => 9
//918 => 17


Console.Write("Enter a three-digit number:   ");
int n = int.Parse(Console.ReadLine()!);
int result = n/100 + (n-n/100*100)-(n-n/100*100)/10*10;
Console.WriteLine(result);