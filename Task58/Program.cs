// 58. Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

Console.Write("Введите количество строк матрицы A: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество столбцов матрицы A: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество строк матрицы B: ");
int l = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество столбцов матрицы B: ");
int d = Convert.ToInt32(Console.ReadLine());
Console.WriteLine();

if (m > 0 && n > 0 && l > 0 && d > 0)
{
    Console.WriteLine("Матрица A:");
    int[,] firstArray2d = CreateMatrixRndInt(m, n, 0, 10);
    PrintMatrix(firstArray2d);
    Console.WriteLine("Матрица B:");
    int[,] secondArray2d = CreateMatrixRndInt(l, d, 0, 10);
    PrintMatrix(secondArray2d);
    if (firstArray2d.GetLength(1) == secondArray2d.GetLength(0))
    {
        Console.WriteLine("Произведение двух матриц:");
        int[,] result = MultiplicationMatrix(firstArray2d, secondArray2d);
        PrintMatrix(result);
    }
    else
    {
        Console.WriteLine("Число столбцов матрицы A не равняется числу строк матрицы B. Умножение невозможно!");
    }
}
else Console.WriteLine("Введены некорректные значения!");

int[,] CreateMatrixRndInt(int rows, int columns, int min, int max)
{
    int[,] matrix = new int[rows, columns];
    Random rnd = new Random();
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = rnd.Next(min, max + 1);
        }
    }
    return matrix;
}

void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i, j],4}");
        }
        Console.WriteLine();
    }
}

int[,] MultiplicationMatrix(int[,] firstMatrix, int[,] secondMatrix)
{
    int[,] matrix = new int[firstMatrix.GetLength(0), secondMatrix.GetLength(1)];
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            int res = 0;
            for (int k = 0; k < firstMatrix.GetLength(1); k++)
            {
                res = res + firstMatrix[i, k] * secondMatrix[k, j];
            }
            matrix[i, j] = res;
            res = 0;
        }
    }
    return matrix;
}