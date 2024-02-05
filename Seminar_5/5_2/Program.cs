// Задайте двумерный массив. Найдите сумму элементов,
// находящихся на главной диагонали (с индексами (0,0); (1;1) и т.д.
// Пример
//  2 3 4 3
//  4 3 4 1  =>  2 + 3 + 5 = 10
//  2 9 5 4

int[,] CreateMatrix(int rowCount, int columsCount)
{
    int[,] matrix = new int[rowCount, columsCount];

    Random rnd = new Random();
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {

            matrix[i, j] = rnd.Next(1, 11);
        }
    }
    return matrix;
}

void ShowMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {

            Console.Write($"{matrix[i, j]} ");
        }
        Console.WriteLine();
    }
}

int rowCount = 4;
int columsCount = 6;

int[,] matrix = CreateMatrix(rowCount, columsCount);
ShowMatrix(matrix);

// int SumOfMainDiagonal(int[,] matrix)
// {
//     int sum = 0;
//     int size = matrix.GetLength(0);
//     for (int i = 0; i < size; i++)
//     {
//         sum += matrix[i, i];
//     }
//     return sum;
// }

int SumOfMainDiagonal(int[,] matrix)
{
    int sum = 0;
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (i==j)
            sum += matrix [i,j];
        }
    }
    return sum;
}

int result = SumOfMainDiagonal(matrix);
Console.WriteLine(result);

