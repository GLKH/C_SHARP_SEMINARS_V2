// Задайте двумерный массив из целых чисел. Сформируйте новый
// одномерный массив, состоящий из средних арифметических
// значений по строкам двумерного массива. 
// Пример
// 2 3 4 3
// 4 3 4 1  => [ 3 3 5 ]
// 2 9 5 4


int[,] CreateMatrix(int rowCount, int columsCount)
{
    int[,] matrix = new int[rowCount, columsCount];

    Random rnd = new Random();
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {

            matrix[i, j] = rnd.Next(1, 10);
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
int columsCount = 8;

int[,] matrix = CreateMatrix(rowCount, columsCount);
ShowMatrix(matrix);

double [] Average (int[,] matrix)
{
    double [] av = new double [matrix.GetLength(0)];
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        double sum =0;
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            sum += matrix[i,j];
        }
        av[i] = sum / matrix.GetLength(1);
    }
    return av;
}

double [] AverageArr = Average (matrix);
foreach (double el in AverageArr)
{
    Console.Write(" " + el);
}