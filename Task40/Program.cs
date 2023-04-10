// 40. Напишите программу, которая принимает на вход три
// числа и проверяет, может ли существовать треугольник с сторонами
// такой длины.
// Теорема о неравенстве треугольника: каждая сторона треугольника
// меньше суммы двух других сторон.

Console.WriteLine($"Введите первую сторону треугольника: ");
int firstSideTriangle = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"Введите вторую сторону треугольника: ");
int secondSideTriangle = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"Введите третью сторону треугольника: ");
int thirdtSideTriangle = Convert.ToInt32(Console.ReadLine());

bool result = IsTriangleExist(firstSideTriangle, secondSideTriangle, thirdtSideTriangle);
string res = result ? "Треугольник с сторонами такой длины может существовать" : "Треугольник с сторонами такой длины не может существовать";
Console.WriteLine(res);

bool IsTriangleExist(int num1, int num2, int num3)
{
    if (num1 < num2 + num3 && num2 < num1 + num3 && num3 < num1 + num2) return true;
    else return false;
}
