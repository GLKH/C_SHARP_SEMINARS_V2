// Задача 2: Задайте массив заполненный случайными
// трёхзначными числами. Напишите программу,
// которая покажет количество чётных чисел в
// массиве.
// Пример
// [344 452 341 125] => 2
void Print(int[] arr)
{
    int size = arr.Length;

    for (int i = 0; i < size; i++)
        Console.Write($"{arr[i]} ");

    Console.WriteLine();
}

int[] MassNums(int size, int from, int to)
{
    int[] arr = new int[size];
    Random n_new = new Random();

    for (int i = 0; i < size; i++)
        arr[i] = n_new.Next(from, to);

    return arr;
}

int CountNum(int[] arr)
{
    int result = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] % 2 == 0)
        result++;
    }
    return result;
}


int num = int.Parse(Console.ReadLine()!);
int start = 100;
int stop = 1000;

int[] mass = MassNums(num, start, stop);
Print(mass);
int res = CountNum(mass);
Console.WriteLine(res);

