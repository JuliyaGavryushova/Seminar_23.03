// 37. Найдите произведение пар чисел в одномерном массиве. Парой считаем первый и
// последний элемент, второй и предпоследний и т.д. Результат запишите в новом массиве

int[] array = CreateArrayRndInt(5, 0, 10);
PrintArray(array);
Console.WriteLine();
PrintArray(ProductPairsArr(array));


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

int[] ProductPairsArr(int[] arr)
{
    int size = arr.Length / 2;
    if (arr.Length % 2 != 0)
    {
        size += 1;
    }
    int[] pairsArr = new int[size];
    for (int i = 0; i < pairsArr.Length; i++)
    {
        pairsArr[i] = arr[i] * arr[arr.Length - 1 - i];
    }
    if (arr.Length % 2 != 0)
    {
        pairsArr[pairsArr.Length - 1] = arr[arr.Length / 2];
    }
    return pairsArr;
}