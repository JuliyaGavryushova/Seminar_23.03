// 29. Напишите программу, которая задает массив из 8 элементов,
// заполненный псевдослучайными числами и выводит их на экран

int[] array = new int[6];

FillArray(array);
PrintArray(array);
Console.Write(" -> [");
PrintArray(array);
Console.WriteLine("]");

void FillArray(int[] userArray)
{
    Random num = new Random();
    for (int i = 0; i < userArray.Length; i++)
    {
        userArray[i] = num.Next(0, 101);
    }
}

void PrintArray(int[] userArray)
{
    for (int i = 0; i < userArray.Length; i++)
    {
        if (i == userArray.Length - 1)
        {
            Console.Write($"{userArray[i]}");
        }
        else
        {
            Console.Write($"{userArray[i]},");
        }
    }
}