// 19. Напишите программу, которая принимает на вход пятизначное число и проверяет,
// является ли оно палиндромом
// 14212 -> нет
// 12821 -> да
// 23432 -> да

Console.WriteLine("Введите пятизначное число: ");
int number = Convert.ToInt32(Console.ReadLine());

String result = PalindromeCheck(number);
Console.WriteLine(result);

string PalindromeCheck(int num)
{
    if (num < 10000 || num > 99999) return "Число не пятизначное";
    int firstNum = num / 10000;
    int secondNum = num / 1000 % 10;
    int fourthNum = num / 10 % 10;
    int fifthNum = num % 10;
    if (firstNum == fifthNum && secondNum == fourthNum) return "Число является палиндромом";
    return "Число не является палиндромом";
}

