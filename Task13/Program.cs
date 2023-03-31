// 13. Напишите программу, которая выводит третью цифру заданного числа
// или сообщает, что третьей цифры нет

Console.WriteLine("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

int result = ThirdDigit(number);
Console.WriteLine(number < 100 ? $"Третьей цифры нет" : result);

int ThirdDigit(int num)
{
    while (num > 999)
    {
        num /= 10;
    }
    return num % 10;
}