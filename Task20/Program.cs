// 20. Напишите программу, которая принимает на вход координаты двух точек и
// находит расстояние между ними в 2D пространстве

// double d = Math.Sqrt(5);
// double num = 5.09987453;
// double numRound = Math.Round(num, 2, MidpointRounding.ToZero);
// Console.WriteLine(numRound);


Console.WriteLine("Введите координаты первой точки");
Console.Write("X:");
int xPoint1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Y:");
int yPoint1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите координаты второй точки");
Console.Write("X:");
int xPoint2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Y:");
int yPoint2 = Convert.ToInt32(Console.ReadLine());

double distancePoint = Distance(xPoint1, yPoint1, xPoint2, yPoint2);
double numRound = Math.Round(distancePoint, 2, MidpointRounding.ToZero);
Console.WriteLine($"Расстояние между двумя точками {numRound}");

double Distance(int x1, int y1, int x2, int y2)
{
    double dist = Math.Sqrt((x2 - x1) * (x2 - x1) + (y2 - y1) * (y2 - y1));
    return dist;
}