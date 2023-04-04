// 30. Напишите программу, которая выводит массив из 8 элементов,
// заполненный нулями и единицами в случайном порядке

int[] array = new int[8];

FillArray(array);
PrintArray(array);

void FillArray(int[] userArray)
{
    Random num = new Random();
    for (int i = 0; i < userArray.Length; i++)
    {
        userArray[i] = num.Next(0, 2);
    }
}

void PrintArray(int[] userArray)
{
    Console.Write("{");
    for (int i = 0; i < userArray.Length; i++)
    {
        if (i == userArray.Length - 1)
        {
            Console.Write($"{userArray[i]}");
        }
        else
        {
            Console.Write($"{userArray[i]}, ");
        }
    }
    Console.Write("}");
}
