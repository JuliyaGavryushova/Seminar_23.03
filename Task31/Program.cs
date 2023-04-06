// 30. Задайте массив из 12 элементов, заполненный случайными числами из 
// промежутка [-9, 9]. Найдите сумму отрицательных и положительных элементов массива

int[] array = CreateArrayRndInt(12, -9, 9);
PrintArray(array);
int sumPositive = SumPositiveElements(array);
int sumNegative = SumNegativeElements(array);
Console.WriteLine();
Console.WriteLine($"Сумма положительных элементов массива => {sumPositive}");
Console.WriteLine($"Сумма отрицательных элементов массива => {sumNegative}");

int[] CreateArrayRndInt(int size, int min, int max)
{
    int[] arr = new int[size];
    Random rnd = new Random();
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = rnd.Next(min, max + 1);
    }
    return arr;
}

void PrintArray(int[] arr)
{
    Console.Write("[");
    for (int i = 0; i < arr.Length; i++)
    {
        if (i == arr.Length - 1)
        {
            Console.Write($"{arr[i]}");
        }
        else
        {
            Console.Write($"{arr[i]}, ");
        }
    }
    Console.Write("]");
}

int SumPositiveElements(int[] arr)
{
    int result = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] > 0)
        {
            result = result + arr[i];
        }
    }
    return result;
}

int SumNegativeElements(int[] arr)
{
    int result = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] < 0)
        {
            result = result + arr[i];
        }
    }
    return result;
}