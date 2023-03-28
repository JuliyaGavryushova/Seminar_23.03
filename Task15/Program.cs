// 15. Напишите программу, которая принимает на вход цифру, обозначающую
// день недели, и проверяет, является ли этот день выходным

Console.WriteLine("Введите число, которому соответствует день недели: ");
int day = Convert.ToInt32(Console.ReadLine());

Weekend(day);

void Weekend(int num)
{
    if (num < 1 || num > 7)
    {
        Console.WriteLine("Такого дня недели не существует!");
    }
    else if (num >= 1 && num <= 5)
    {
        Console.WriteLine("Не выходной!");
    }
    else if (num == 6 || num == 7)
    {
        Console.WriteLine("Выходной!");
    }
}