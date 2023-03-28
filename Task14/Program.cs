// 14. Напишите программу, которая принимает на вход число
// и проверяет, кратно ли оно одеовременно 7 и 23

Console.WriteLine("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

bool result = IsMultipleTwoNumbers(number);
Console.WriteLine(result ? "Число кратно" : "Число не кратно");

bool IsMultipleTwoNumbers(int num)
{
    return num % 7 == 0 && num % 23 == 0;
}