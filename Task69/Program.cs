// 69. Напишите программу, которая на вход принимает два числа А и В,
// и возводит число А в целую степень В с помощью рекурсии

Console.WriteLine("Введите число A:");
int numberA = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число B:");
int numberB = Convert.ToInt32(Console.ReadLine());

if (numberB > 0)
{
    int result = Exponentiation(numberA, numberB);
    Console.WriteLine(result);
}
else Console.WriteLine("Некорректный ввод!");

int Exponentiation(int numA, int numB)
{
    if (numB == 0) return 1;
    else return numA * Exponentiation(numA, numB - 1);
}