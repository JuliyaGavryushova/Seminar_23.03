// 9. Напишите программу, которая выводит
// случайное число из отрезка [10, 99] и показывает
// наибольшую цифру числа

int numberRandom = new Random().Next(10, 100);
Console.WriteLine($"Случайное число из отрезка [10, 99] => {numberRandom}");

// ПРОСТОЙ МЕТОД:
// int firstDigit = numberRandom / 10;
// int secondDigit = numberRandom % 10;
// if (firstDigit > secondDigit) Console.WriteLine($"Наибольшая цифра числа => {firstDigit}");
// else Console.WriteLine($"Наибольшая цифра числа => {secondDigit}");

// ТЕРНАРНЫЙ ОПЕРАТОР:
// int maxDigit = firstDigit > secondDigit ? firstDigit : secondDigit;

// МЕТОД С ФУНКЦИЕЙ:
int maxDigit = MaxDigit(numberRandom);
Console.WriteLine($"Наибольшая цифра числа => {maxDigit}");

int MaxDigit(int numRandom)
{
    int firstDigit = numRandom / 10;
    int secondDigit = numRandom % 10;
    int maxDigit = firstDigit > secondDigit ? firstDigit : secondDigit;
    return maxDigit;
}