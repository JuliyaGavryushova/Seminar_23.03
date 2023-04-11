// 43. Напишите программу, которая найдёт точку пересечения двух прямых, 
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

Console.WriteLine("Введите значения k1 и b1 уравнения y = k1 * x + b1");
Console.Write("Введите k1: ");
int k1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите b1: ");
int b1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите значения k2 и b2 уравнения y = k2 * x + b2");
Console.Write("Введите k2: ");
int k2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите b2: ");
int b2 = Convert.ToInt32(Console.ReadLine());

double xCoordinatesPoint = XPointIntersection(k1, b1, k2, b2);
double yCoordinatesPoint = Math.Round(YPointIntersection(k1, b1, xCoordinatesPoint), 1, MidpointRounding.ToZero);
Console.Write($"Координаты точки пересечения двух прямых -> ({xCoordinatesPoint}; {yCoordinatesPoint})");

double XPointIntersection(int a, int b, int c, int d)
{
    double n = d - b;
    double x = n / (a - c);
    return x;
}

double YPointIntersection(int a, int b, double x)
{
    double y = a * x + b;
    return y;
}