//Напишите программу, которая принимает
//на вход число и проверяет, кратно ли оно одновременно 7 и 23
//Пример
// a=50 => нет
// a=7 => нет
// a=322 => да

Console.Write("Enter a number:  ");
int a = int.Parse(Console.ReadLine()!);

if (a % 7 == 0 && a % 23 == 0)
{
    Console.WriteLine("Yes");
}
else
{
    Console.WriteLine("No");
}