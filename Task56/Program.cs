// 56. Задайте прямоугольный двумерный массив. Напишите программу, которая будет
// находить строку с наименьшей суммой элементов.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт номер 
// строки с наименьшей суммой элементов: 1 строка

int[,] array2d = CreateMatrixRndInt(4, 3, 0, 10);
PrintMatrix(array2d);
int[] sumElement = SumElementRow(array2d);
int result = MinElementArray(sumElement);
Console.WriteLine($"Строка с наименьшей суммой элементов => {result}");

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

int[] SumElementRow(int[,] matrix)
{
    int[] arr = new int[matrix.GetLength(0)];
    int sum = 0;
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            sum += matrix[i, j];
        }
        arr[i] = sum;
        sum = 0;
    }
    return arr;
}

int MinElementArray(int[] arr)
{
    int minPosition = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] < arr[minPosition]) minPosition = i;
    }
    int res = minPosition + 1;
    return res;
}