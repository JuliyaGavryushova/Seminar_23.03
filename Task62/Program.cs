// 62. Напишите программу, которая заполнит спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07

int[,] array2d = CreateMatrixRndInt(4, 4, 1, 100);
PrintMatrix(array2d);

int[,] CreateMatrixRndInt(int rows, int columns, int min, int max)
{
    int[,] matrix = new int[rows, columns];
    int count = 0;
    for (int i = 0; i < matrix.GetLength(0) / 4; i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = min + count;
            count++;
        }
        for (int k = i + 1; k < matrix.GetLength(1) - 1; k++)
        {
            matrix[k, matrix.GetLength(1) - 1 - i] = min + count;
            count++;
        }
        for (int l = matrix.GetLength(1) - i - 1; l >= i + 1; l--)
        {
            matrix[matrix.GetLength(1) - i - 1, l] = min + count;
            count++;
        }
        for (int m = matrix.GetLength(0) - 1; m > i; m--)
        {
            matrix[m, i] = min + count;
            count++;
        }
    }
    for (int n = 1; n < matrix.GetLength(0) / 2; n++)
    {
        for (int p = n; p < matrix.GetLength(1) - n; p++)
        {
            matrix[n, p] = min + count;
            count++;
        }
        for (int t = matrix.GetLength(1) - n - 1; t > 0; t--)
        {
            matrix[n + 1, t] = min + count;
            count++;
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
            Console.Write($"{matrix[i, j],6}");
        }
        Console.WriteLine();
    }
}