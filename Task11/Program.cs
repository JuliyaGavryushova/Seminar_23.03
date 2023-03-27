// 11. Напишите программу, которая выводит случайное
// трёхзначное число и удаляет вторую цифру этого
// числа

int numberRandom = new Random().Next(100, 1000);
Console.WriteLine($"Случайное трехзначное число => {numberRandom}");

int delSecondDigit = DelSecondDigit(numberRandom);
Console.WriteLine($"{delSecondDigit}");

int DelSecondDigit(int numRandom)
{
    int firstDigit = numRandom / 100;
    int secondDigit = numRandom % 10;
    int DelSecondDigit = firstDigit * 10 + secondDigit;
    return DelSecondDigit;
}