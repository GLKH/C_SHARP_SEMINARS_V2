// Заполните массив на N (вводится с консоли, не более 8)
// случайных целых чисел от 0 до 9.
// Сформируйте целое число, которое будет состоять из цифр из
// массива. Старший разряд числа находится на 0-м индексе,
// младший – на последнем.
// Пример
// [1 3 2 4 2 3] => 132423
// [2 3 1] => 231

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

int NumberFromMass(int[] arr)
{
    int result = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        result = result*10 + arr[i];
    }
    return result;
}

// Вариант решения от преподавателя. 
// Вывесим элементы массива по очереди в строку
// и потом преобразовать в число:

// long NumberFromMass(int[] arr) 
// {
//     string word = "":

//     foreach (int number in arr)
//     {
//         word += number;
//     }
//     return long.Parse(word);
// }

int num = int.Parse(Console.ReadLine()!);
int start = int.Parse(Console.ReadLine()!);
int stop = int.Parse(Console.ReadLine()!);

int[] mass = MassNums(num, start, stop);
Print(mass);
int res = NumberFromMass(mass);
Console.WriteLine(res);

