// 33. Задайте массив. Напишите программу, которая определяет,
// присутствует ли заданное число в массиве

int[] array = { 24, -4, 0, 87, 3, 2, 1, 55, -100 };
Console.WriteLine("Введите число для проверки наличия его в массиве:");
int number = Convert.ToInt32(Console.ReadLine());

bool result = IsDigitInArray(array, number);
Console.WriteLine(result ? "Да" : "Нет");

bool IsDigitInArray(int[] arr, int num)
{
    for (int i = 0; i < arr.Length; i++)
    {
        if (num == arr[i]) return true;
    }
    return false;
}