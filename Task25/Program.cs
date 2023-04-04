// 25. Напишите цикл, который принимает на вход два числа (А и В)
// и возводит число А в натуральную степень В

Console.Write("Введите число А: ");
int number1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите натуральное число В: ");
int number2 = Convert.ToInt32(Console.ReadLine());
if (number2 > 0)
{
    int res = Exponentiation(number1, number2);
    Console.WriteLine($"{number1} в степени {number2} => {res}");
}
else
{
    Console.WriteLine("Вы ввели некорректное значение числа В!");
}

int Exponentiation(int num1, int num2)
{
    int result = 1;
    for (int i = 1; i <= num2; i++)
    {
        checked
        {
            result = result * num1;
        }
    }
    return result;
}