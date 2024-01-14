// Найдите произведения пар чисел в одномерном массиве. Парой
// считаем первый и последний элемент, второй и предпоследний и
// т.д. Результат запишите в новый массив.
// Пример
// [1 3 2 4 2 3] => [3 6 8]
// [2 3 1 7 5 6 3] => [6 18 5] (элемент 7 не имеет пары)

int[] arr = new int[] { -10, 6, 7, -3, 4, 2, -1, 0, 6, 5, 1 };
int i = 0;
int j = arr.Length;
while (i < arr.Length/2)
{
    arr[i] = arr[i] * arr[j - 1];
    Console.Write(arr[i] + " ");
    i = i + 1;
    j = j - 1;
}


// ДРУГОЙ СПОСОБ ЧЕРЕЗ FOR

// int[] numbers = { 10, 8, 6, 4, 2, 1, 3, 5, 7, 9 };
//         int[] res = new int[numbers.Length / 2];
       
//         for(int i = 0; i < numbers.Length / 2;  i++) {
//             res[i] = numbers[i] * numbers[numbers.Length - 1 - i];
//             Console.WriteLine("Результат :" + res[i]);
//         }


// РЕШЕНИЕ ЗАДАЧИ ОТ ПРЕПОДАВАТЕЛЯ (оно более сложное: если массив с нечетным кол-вом элементов,
// то элемент по середине выводится в середину нового массива)


// это блок вывода созданного массива

// void Print(int[] arr)
// {
//     int size = arr.Length;

//     for (int i = 0; i < size; i++)
//         Console.Write($"{arr[i]} ");
//     Console.WriteLine();
// }

// это блок создания исходного массива

// int[] MassNums(int size, int from, int to)
// {
//     int[] arr = new int[size];

//     for (int i = 0; i < size; i++)
//         arr[i] = new Random().Next(from, to + 1);
//     return arr;
// }

// это блок решения с созданием нового массива

// int[] PairsNum(int[] arr)
// {
//     int size = arr.Length;
//     int flex_size = size / 2 + size % 2;
//     int[] new_arr = new int[flex_size];

//     for (int i = 0; i < size / 2; i++)
//         new_arr[i] = arr[i] * arr[size - i - 1];

//     if (size % 2 == 1)
//         new_arr[flex_size - 1] = arr[size / 2];
//     return new_arr;
// }

// int num = int.Parse(Console.ReadLine()!);
// int start = int.Parse(Console.ReadLine()!);
// int stop = int.Parse(Console.ReadLine()!);

// int[] mass = MassNums(num, start, stop);
// Print(mass);
// int[] arr_new = PairsNum(mass);
// Print(arr_new);