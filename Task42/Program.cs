// 42. Напишите программу, которая будет преобразовывать
// десятичное число в двоичное.
// 45 -> 101101
// 3 -> 11
// 2 -> 10

Console.WriteLine($"Введите десятичное число: ");
int decimalNumber = Convert.ToInt32(Console.ReadLine());

// string res = DecToBin(decimalNumber);
// Console.WriteLine(res);

int res = DecToBinWithIng(decimalNumber);
Console.WriteLine(res);

// string DecToBin(int dec)
// {
//     string temp = string.Empty;
//     while (dec > 0)
//     {
//         temp = dec % 2 + temp;
//         dec = dec / 2;
//     }
//     return temp;
// }

int DecToBinWithIng(int dec)
{
    int result = 0;
    int count = 1;
    while (dec > 0)
    {
        result = result + dec % 2 * count;
        dec = dec / 2;
        count = count * 10;
    }
    return result;
}