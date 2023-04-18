// 59. Задайте двумерный массив из целых чисел.
// Напишите программу, которая удалит строку и столбец, на
// пересечении которых расположен наименьший элемент
// массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Наименьший элемент - 1, на выходе получим
// следующий массив:
// 9 2 3
// 4 2 4
// 2 6 7

int[,] array2d = CreateMatrixRndInt(3, 4, 0, 10);
PrintMatrix(array2d);
Console.WriteLine();
int[] index = MinElementOfMatrix(array2d);
int[,] newArray2d = RemoveRowColumnMinElement(array2d, index);
PrintMatrix(newArray2d);

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

int[] MinElementOfMatrix(int[,] arr)
{
    int[] indexes = new int[] { 0, 0 };
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            if (arr[i, j] < arr[indexes[0], indexes[1]])
            {
                indexes[0] = i;
                indexes[1] = j;
            }
        }
    }
    return indexes;
}

int[,] RemoveRowColumnMinElement(int[,] originalMatrix, int[] indexes)
{
    int[,] newMatrix = new int[originalMatrix.GetLength(0) - 1, originalMatrix.GetLength(1) - 1];
    int m = 0;
    int n = 0;
    for (int i = 0; i < newMatrix.GetLength(0); i++)
    {
        if (m == indexes[0]) m++;
        for (int j = 0; j < newMatrix.GetLength(1); j++)
        {
            if (n == indexes[1]) n++;

            newMatrix[i, j] = originalMatrix[m, n];
            n++;
        }
        m++;
        n = 0;
    }
    return newMatrix;
}

