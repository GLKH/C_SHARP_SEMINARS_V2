//Напишите программу, которая принимает
//на вход координаты точки (X и Y), причём X ≠ 0 и Y ≠ 0
//и выдаёт номер координатной четверти плоскости,
//в которой находится эта точка.
// Пример
//  2, 3 => 1
// -5, 3 => 2
// -3, -2 => 3
//  4, -2 => 4

Console.Write("Enter a first number:  ");
int x = int.Parse(Console.ReadLine()!);
Console.Write("Enter a second number:  ");
int y = int.Parse(Console.ReadLine()!);

if (x > 0 && y > 0)
{
    Console.WriteLine("The coordinate quarter - 1");
}
if (x < 0 && y > 0)
{
    Console.WriteLine("The coordinate quarter - 2");
}
if (x < 0 && y < 0)
{
    Console.WriteLine("The coordinate quarter - 3");
}
if (x > 0 && y < 0)
{
    Console.WriteLine("The coordinate quarter - 4");
}