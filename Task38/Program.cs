// 38. Задайте массив вещественных чисел. Найдите разницу между 
// максимальным и минимальным элементами массива

double[] array = CreateArrayRndDouble(10, 1, 15);
PrintArray(array);
Console.WriteLine();
double maxNum = Math.Round(FindMaxElement(array), 1, MidpointRounding.ToZero);
double minNum = Math.Round(FindMinElement(array), 1, MidpointRounding.ToZero);
double difMaxNumMinNum = Math.Round(DifferenceMaxMin(maxNum, minNum), 1, MidpointRounding.ToZero);
Console.WriteLine($"Разница между максимальным и минимальным элементами массива => {difMaxNumMinNum}");

double[] CreateArrayRndDouble(int size, int min, int max)
{
    double[] arr = new double[size];
    Random rnd = new Random();
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = rnd.NextDouble() * (max - min) + min;
    }
    return arr;
}

void PrintArray(double[] arr)
{
    Console.Write("[");
    for (int i = 0; i < arr.Length; i++)
    {
        if (i == arr.Length - 1)
        {
            Console.Write($"{Math.Round(arr[i], 1, MidpointRounding.ToZero)}");
        }
        else
        {
            Console.Write($"{Math.Round(arr[i], 1, MidpointRounding.ToZero)},  ");
        }
    }
    Console.Write("]");
}

double FindMaxElement(double[] arr)
{
    double maxElement = arr[0];
    for (int i = 1; i < arr.Length; i++)
    {
        if (arr[i] > maxElement)
        {
            maxElement = arr[i];
        }
    }
    return maxElement;
}

double FindMinElement(double[] arr)
{
    double minElement = arr[0];
    for (int i = 1; i < arr.Length; i++)
    {
        if (arr[i] < minElement)
        {
            minElement = arr[i];
        }
    }
    return minElement;
}

double DifferenceMaxMin(double max, double min)
{
    double dif = max - min;
    return dif;
}