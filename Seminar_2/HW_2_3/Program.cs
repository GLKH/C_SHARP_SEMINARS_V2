// Напишите программу, которая принимает
// на вход целое число из отрезка [10, 99] и показывает наибольшую цифру числа.
// Пример
// 40 => 4
// 96 => 9
// 72 => 7

Console.Write("Enter a number between 10 and 99:   ");
int a = int.Parse(Console.ReadLine()!);

if (a >= 10 && a < 100)
{
    int a1 = a / 10;
    int a2 = a % 10;
    if (a1 > a2)
    {
        Console.WriteLine(a1);
    }
    else
    {
        Console.WriteLine(a2);
    }
}
else
{
    Console.WriteLine("You entered a number outside the specified range. Please be careful!");
}

