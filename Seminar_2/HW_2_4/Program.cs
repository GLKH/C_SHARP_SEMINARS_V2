// Напишите программу, которая на вход
// принимает натуральное число N, а на выходе
// показывает его цифры через запятую.
// Пример
//  568 => 5,6,8
//    8 => 8
// 9542 => 9,5,4,2



Console.Write("Enter a number:  ");
int a = int.Parse(Console.ReadLine()!);

// Решение ниже разделяет число и переставляет цифры в обратном порядке: 

//int count = a;

// while (count > 0)
// {
//     Console.Write(count % 10 + " ");
//     count = count / 10;
// }


// Этот блок считает сколько цифр в числе

int count1 = 0;
int b = a;
while (b > 0)
{
    b = b / 10;
    count1++;
}

// Это вывод количества цифр в числе для контроля
// Console.WriteLine(count1);



int count2 = count1 - 1;
while (count2 >= 0)
{
    Console.Write(Math.Truncate(a/Math.Pow(10,count2) % 10) + ", ");
    count2 = count2 - 1;
}

// Сделано для красоты, чтобы ответ не сливался с командной строкой
Console.WriteLine("");