// 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве,
// и возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет

Console.Write("Введите строку элемента: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите столбец элемента: ");
int m = Convert.ToInt32(Console.ReadLine());

int[,] array2d = CreateMatrixRndInt(3, 4, -100, 100);
PrintMatrix(array2d);
SearchElement(array2d, n, m);


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
            Console.Write($"{matrix[i, j],6}");
        }
        Console.WriteLine();
    }
}

void SearchElement(int[,] matrix, int i, int j)
{
    if (i < matrix.GetLength(0) && j < matrix.GetLength(1))
    {
        Console.WriteLine($"Элемент массива с заданными параметрами -> {matrix[i, j]}");
    }
    else Console.WriteLine("Такого числа в массиве нет");
}