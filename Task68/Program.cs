// 68. Напишите программу вычисления функции Аккермана с помощью рекурсии. 
// Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29

Console.WriteLine("Введите число m:");
int numberM = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число n:");
int numberN = Convert.ToInt32(Console.ReadLine());

if (numberM >= 0 && numberN >= 0)
{
    int result = AckermanFunctions(numberM, numberN);
    Console.WriteLine($"A(m,n) = {result}");
}
else Console.WriteLine("Некорректный ввод!");

// int AckermanFunctions(int m, int n)
// {
//     if (m == 0) return n + 1;
//     if (n == 0) return AckermanFunctions(m - 1, 1);
//     return AckermanFunctions(m - 1, AckermanFunctions(m, n - 1));
// }

int AckermanFunctions(int m, int n)
{
    while (m != 0)
    {
        if (n == 0) n = 1;
        else n = AckermanFunctions(m, n - 1);
        m = m - 1;
    }
    return n + 1;
}