// 26. Напишите программу, которая принимает на вход число
// и выдает количество цифр в числе

Console.Write("Введите число: ");
int number = Math.Abs(Convert.ToInt32(Console.ReadLine()));

int result = HowManyDigits(number);
Console.WriteLine($"В числе {result} цифр");

int HowManyDigits(int num)
{
    int count = 0;
    while (num > 0)
    {
        num /= 10;
        count++;
    }
    return count;
}