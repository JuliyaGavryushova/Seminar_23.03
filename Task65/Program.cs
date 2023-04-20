// 65. Задайте значения M и N. Напишите программу, которая
// выведет все натуральные числа в промежутке от M до N.

Console.WriteLine("Введите первое натуральное число:");
int firstNumber = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе натуральное число:");
int secondNumber = Convert.ToInt32(Console.ReadLine());

if (firstNumber > 0 && secondNumber > 0)
{
    IntervalNaturalNumbers(firstNumber, secondNumber);
}
else Console.WriteLine("Некорректные данные");

void IntervalNaturalNumbers(int n, int m)
{
    if (n < m)
    {
        Console.Write($"{n} ");
        IntervalNaturalNumbers(n + 1, m);
    }
    else if (n > m)
    {
        Console.Write($"{n} ");
        IntervalNaturalNumbers(n - 1, m);
    }
    else Console.Write($"{n} ");
}