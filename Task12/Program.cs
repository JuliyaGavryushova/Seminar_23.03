// 12. Напишите программу, которая будет принимать на вход два числа
// и выводить, является ли первое число кратным второму. Если число 1 не кратно
// числу 2, то программа выводит остаток от деления

Console.WriteLine("Введите первое число: ");
int number1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число: ");
int number2 = Convert.ToInt32(Console.ReadLine());

int remainderDivision = RemainderDivision(number1, number2);
WriteResult(remainderDivision);

int RemainderDivision(int num1, int num2)
{
    int result = num1 % num2;
    return result;
}

void WriteResult(int remainder)
{
    if (remainder == 0) Console.WriteLine("кратно");
    else Console.WriteLine($"не кратно, остаток {remainder}");
}