//Напишите программу, которая на вход принимает
//целое число N, а на выходе показывает все целые
//числа в промежутке от -N до N.
//Примеры
//4 => -4, -3, -2, -1, 0, 1, 2, 3, 4
//2 => -2, -1, 0, 1, 2

Console.Write("Enter a number: ");
int n = int.Parse(Console.ReadLine()!);

int count = -n;  // это счетчик

while (count <= n)
{
    Console.Write(count + " ");
    count++;   // по другому этом "count = count+1"
}