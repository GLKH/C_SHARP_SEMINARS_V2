//Задайте массив. Напишите программу, которая определяет,
//присутствует ли заданное число в массиве. Программа
//должна выдать ответ: Да/Нет.
//Примеры
//[1 3 4 19 3], 8 => Нет
//[-4 3 4 1], 3 => Да


Console.WriteLine("Введите значение");
int a = int.Parse(Console.ReadLine()!);

int[] arr = { 1, 2, 3, 4, 5 };
int i = 0;
bool found = false;

while (i < arr.Length)
{
    if (a == arr[i])
    {
        found = true;
        break;
    }
    i = i + 1;
}

if (found)
{
    Console.WriteLine("Da");
}
else
{
    Console.WriteLine("Net");
}