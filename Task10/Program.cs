// 10. Напишите программу, которая принимает на вход трехзначное число
// и на выходе показывает вторую цифру этого числа

Console.WriteLine("Введите трехзначное число: ");
int number = Convert.ToInt32(Console.ReadLine());

int result = SecondDigit(number);
Console.WriteLine($"Вторая цифра числа {result}");

int SecondDigit(int num)
{
    int twoDigitNumber = num / 10;
    int secondDigit = twoDigitNumber % 10;
    return secondDigit;
}

