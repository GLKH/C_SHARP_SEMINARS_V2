//Напишите программу, которая принимает на вход трёхзначное
//число и возводит вторую цифру этого числа в степень, равную третьей цифре.
// Примеры
// 487 => 8^7 = 2 097 152
// 254 => 5^4 = 625
// 617 => 1

Console.Write("Enter a three-digit number:   ");
int a = int.Parse(Console.ReadLine()!);

if (a >= 100 && a < 1000)
{
    int a1 = a % 100 / 10;
    int a2 = a % 10;
    double result = Math.Pow(a1, a2);
    Console.WriteLine(result);
}
else
{
    if (a < 100 || a > 1000)
    {
        Console.WriteLine("You entered a non-three digit number");
    }
}


// Решение задачи в коротком варианте:

Console.Write("Enter a three-digit number:   ");
int b = int.Parse(Console.ReadLine()!);
Console.WriteLine(Math.Pow(b % 100 /10, b % 10));


// Math.Pow(a1,a2) - это функция возведения числа в степень (первое число - то, которое возводят в степень,
// второе - сама степень числа)

// 123 % 10   --> 3
// 123 % 100  --> 23
// 123 % 1000 --> 123

// 123 / 10   --> 12
// 123 / 100  --> 1
// 123 / 1000 --> 0

