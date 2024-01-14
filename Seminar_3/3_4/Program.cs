// Дано натуральное трёхзначное число. Создайте массив, состоящий из
// цифр этого числа. Младший разряд числа должен располагаться на 0-
// м индексе массива, старший – на 2-м.
// Пример
// 456 => [6 5 4]
// 781 => [1 8 7]

Console.Write("Enter a number between 100 and 999:   ");
int a = int.Parse(Console.ReadLine()!);

if (a >= 100 && a < 1000)
{
    Console.Write("[");
    for (int i = 0; i < 3; i = i + 1)
    {
        Console.Write(Math.Truncate(a / Math.Pow(10, i) % 10) + " ");
    }
    Console.Write("]");
}
else
{
    Console.WriteLine("You entered a number outside the specified range. Please be careful!");
}
