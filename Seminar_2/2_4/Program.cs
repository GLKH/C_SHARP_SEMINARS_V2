//Напишите программу, которая выводит третью с конца
//цифру заданного числа или сообщает, что третьей цифры нет.
// 456 => 6
// 7812 => 8
// 91 => Третьей цифры нет

Console.Write("Enter a number:   ");
int n = int.Parse(Console.ReadLine()!);

if (n >= 100)
{
    Console.WriteLine(n % 1000 / 100);
}
else
{
    Console.WriteLine("There is no third digit");
}