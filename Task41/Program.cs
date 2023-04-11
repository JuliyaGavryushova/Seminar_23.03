// 41. Пользователь вводит с клавиатуры M чисел. 
// Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// -1, -7, 567, 89, 223-> 3

Console.WriteLine("Сколько чисел хотите ввести? ");
int number = Convert.ToInt32(Console.ReadLine());

if (number > 0)
{
    int[] array = EnteringNumbers(number);
    int result = PositiveDigitsArr(array);
    Console.WriteLine($"Количество чисел больше 0 равно {result}");
}
else Console.WriteLine("Вы ввели некорректное значение");

int[] EnteringNumbers(int num)
{
    int[] arr = new int[num];
    for (int i = 0; i < arr.Length; i++)
    {
        Console.WriteLine("Введите число: ");
        arr[i] = Convert.ToInt32(Console.ReadLine());
    }
    return arr;
}

int PositiveDigitsArr(int[] arr)
{
    int count = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] > 0) count++;
    }
    return count;
}