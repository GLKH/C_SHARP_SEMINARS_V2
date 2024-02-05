// Задайте двумерный массив. Найдите элементы, у которых оба
// индекса чётные, и замените эти элементы на их квадраты.
// Пример
//  2 3 4 3     *4* 3 *16* 3
//  4 3 4 1 =>   4  3   4  1
//  2 9 5 4     *4* 9 *25* 4

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

int rowCount = 5;
int columsCount = 6;

int[,] matrix = CreateMatrix(rowCount, columsCount);
ShowMatrix(matrix);

int[,] MatrixWithIvenIndexes(int[,] matrix, int rowCount, int columsCount)
{
    for (int i = 0; i < rowCount; i += 2)
    {
        for (int j = 0; j < columsCount; j += 2)
        {
            matrix[i, j] = matrix[i, j] * matrix[i, j];
        }
    }
    return matrix;
}

Console.WriteLine();

int[,] matrix1 = MatrixWithIvenIndexes(matrix, rowCount , columsCount);
ShowMatrix(matrix1);