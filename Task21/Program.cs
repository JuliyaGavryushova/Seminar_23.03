// 21. Напишите программу, которая принимает на вход координаты двух точек
// и находит расстояние между ними в 3D пространстве
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53

Console.WriteLine("Введите координаты первой точки");
Console.Write("X: ");
int xPoint1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Y: ");
int yPoint1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Z: ");
int zPoint1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координаты второй точки");
Console.Write("X: ");
int xPoint2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Y: ");
int yPoint2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Z: ");
int zPoint2 = Convert.ToInt32(Console.ReadLine());

double distancePoint = Distance(xPoint1, yPoint1, zPoint1, xPoint2, yPoint2, zPoint2);
double numRound = Math.Round(distancePoint, 2, MidpointRounding.ToZero);
Console.WriteLine($"Расстояние между двумя точками {numRound}");

double Distance(int x1, int y1, int z1, int x2, int y2, int z2)
{
    double dist = Math.Sqrt((x2 - x1) * (x2 - x1) + (y2 - y1) * (y2 - y1) + (z2 - z1) * (z2 - z1));
    return dist;
}