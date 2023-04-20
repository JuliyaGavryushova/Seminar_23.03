// 67. Напишите программу, которая будет принимать на вход число и
// возвращать сумму его цифр

Console.WriteLine("Введите число:");
int number = Convert.ToInt32(Console.ReadLine());

int result = SumDigits(number);
Console.WriteLine($"Сумма цифр в числе => {result}");

int SumDigits(int num)
{
    if (num == 0) return 0;
    else return num % 10 + SumDigits(num / 10);
}