// 66. Задайте значения M и N. Напишите программу, которая найдёт
// сумму натуральных элементов в промежутке от M до N. Выполнить с помощью рекурсии.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

Console.WriteLine("Введите первое натуральное число:");
int firstNumber = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе натуральное число:");
int secondNumber = Convert.ToInt32(Console.ReadLine());

if (firstNumber > 0 && secondNumber > 0)
{
    int result = SumNaturalDigits(firstNumber, secondNumber);
    Console.WriteLine(result);
}
else Console.WriteLine("Некорректный ввод!");

int SumNaturalDigits(int numM, int numN)
{
    if (numM == numN) return numN;
    if (numM < numN) return numM + SumNaturalDigits(numM + 1, numN);
    else return numM + SumNaturalDigits(numM - 1, numN);
}