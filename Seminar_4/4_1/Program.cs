// Задайте одномерный массив, заполненный случайными
// числами. Определите количество простых чисел (простеые числа - это числа, которые 
// деляться только на 1 или сами на себя,
// например, 1, 2, 3, 7, 11, 13, 17 и т.д.) в этом массиве.
// Примеры
// [1 3 4 19 3] => 2
// [4 3 4 1 9 5 21 13] => 3


void Print(double[] arr)
{
    int size = arr.Length;

    for (int i = 0; i < size; i++)
        Console.Write($"{arr[i]} ");

    Console.WriteLine();
}

double[] MassNums(int size, int from, int to)
{
    double[] arr = new double[size];
    Random n_new = new Random();

    for (int i = 0; i < size; i++)
        arr[i] = n_new.Next(from, to);

    return arr;
}

int CountSimpleNum(double[] arr)
{
    int Count = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (FindSimpleNun(arr[i]))
        {
            Count++;
        }
    }
    return Count;
}
bool FindSimpleNun(double NN)
{
    if (NN < 2)
        return false;
    for (int i = 2; i < NN; i++)
    {
        if (NN % i == 0)
            return false;
    }
    return true;
}
int num = int.Parse(Console.ReadLine()!);
int start = int.Parse(Console.ReadLine()!);
int stop = int.Parse(Console.ReadLine()!);

double[] mass = MassNums(num, start, stop);
Print(mass);
int MMM = CountSimpleNum(mass);
Console.WriteLine(MMM);
