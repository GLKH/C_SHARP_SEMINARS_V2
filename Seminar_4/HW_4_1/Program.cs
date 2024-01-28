// Задача 1: Напишите программу, которая бесконечно
// запрашивает целые числа с консоли. Программа
// завершается при вводе символа ‘q’ или при вводе
// числа, сумма цифр которого четная.
// Пример
// 5 12 16 q [STOP]
// 3 45 342 15 [STOP]

while (true)
{
    Console.WriteLine("Введите целое число или букву 'q' для выхоа: ");
    string input = Console.ReadLine();
    if (input == "q")
    {
        Console.WriteLine("[STOP]");
        break;
    }
    int value = Convert.ToInt32(input);
    int sum = 0;
    while (value > 0)
    {
        sum = sum + value % 10;
        value = value / 10;
    }

    if (sum % 2 == 0)
    {
        Console.WriteLine("[STOP]");
        break;
    }

}
