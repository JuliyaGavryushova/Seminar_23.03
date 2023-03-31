// 23. Напишите программу, которая принимает на вход число (N)
// и выдаёт таблицу кубов чисел от 1 до N
// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125

Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

string result = TableSquare(number);
Console.Write(result);

string TableSquare(int num)
{
    string tableSquareResult = "___________\n";
    for (int i = 1; i <= num; i++)
    {
        tableSquareResult = tableSquareResult + $"|{i,3} | {Math.Pow(i, 3),3}| \n";
    }
    tableSquareResult = tableSquareResult + "-----------";
    return tableSquareResult;
}
