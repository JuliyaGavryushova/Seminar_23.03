// 28. Напишите программу, которая принимает на вход число N и 
// выдает произведение чисел от 1 до N

Console.Write("Введите натуральное число: ");
int number = Convert.ToInt32(Console.ReadLine());
if (number > 0)
{
    int result = ProductNumbers(number);
    Console.WriteLine($"Произведение чисел от 1 до {number} равно {result}");
}
else
{
    Console.WriteLine("Некорректное число!");
}

int ProductNumbers(int num)
{
    int product = 1;
    for (int i = 1; i <= num; i++)
    {
        checked
        {
            product = product * i;
        }
    }
    return product;
}
