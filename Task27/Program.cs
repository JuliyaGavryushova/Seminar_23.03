// 27. Напишите программу, которая принимает на вход число 
// и выдает сумму цифр в числе

Console.Write("Введите число: ");
int number = Math.Abs(Convert.ToInt32(Console.ReadLine()));

int result = SumDigits(number);
Console.WriteLine($"Сумма цифр в числе => {result}");

int SumDigits(int num)
{
    int sum = 0;
    while (num > 0)
    {
        int oneDigit = num % 10;
        sum = sum + oneDigit;
        num = num / 10;
    }
    return sum;
}