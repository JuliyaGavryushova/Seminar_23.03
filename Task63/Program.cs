// 63. Задайте значение N. Напишите программу, которая выведет все
// натуральные числа от 1 до N.

Console.WriteLine("Введите натуральное число:");
int number = Convert.ToInt32(Console.ReadLine());

if (number > 0)
{
    NaturalNumbers(number);
}
else Console.WriteLine("Ввели некорректное число");

void NaturalNumbers(int num)
{
    if (num == 0) return;
    NaturalNumbers(num - 1);
    Console.Write($"{num} ");
}