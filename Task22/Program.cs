// 22. Напишите программу, которая принимает на вход число (N) и выдаёт таблицу
// квадратов чисел от 1 до N

Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

string result = TableSquare(number);
Console.Write(result);

string TableSquare(int num)
{
    string tableSquareResult = "___________\n";
    for (int i = 1; i <= num; i++)
    {
        tableSquareResult = tableSquareResult + $"|{i,3} | {i * i,3}| \n";
    }
    tableSquareResult = tableSquareResult + "-----------";
    return tableSquareResult;
}


