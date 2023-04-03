// 24. Напишите программу, которая принимает на вход число (A)
// и выдает сумму чисел от 1 до А

Console.Write("Введите натуральное число: ");
int number = Convert.ToInt32(Console.ReadLine());

int result = SumNumbers(number);
Console.WriteLine($"Сумма чисел от 1 до {number} равна {result}");

int SumNumbers(int num)
{
    int sum = 0;
    for (int i = 1; i <= num; i++)
    {
        sum = sum + i;
    }
    return sum;
}