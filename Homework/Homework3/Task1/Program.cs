// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");

// Напишите программу, которая принимает на вход пятизначное 
// число и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да

    
Console.WriteLine("Введите пятизначное число:");
int number = int.Parse(Console.ReadLine());

bool isPalindrome = IsPalindrome(number);

    if (isPalindrome)
    {
            Console.WriteLine("Число является палиндромом");
    }
    else
        {
            Console.WriteLine("Число не является палиндромом");
        }
    

bool IsPalindrome(int number)
{
    string numberString = number.ToString();
    int length = numberString.Length;

        for (int i = 0; i < length / 2; i++)
        {
            if (numberString[i] != numberString[length - 1 - i])
            {
                return false;
            }
        }

    return true;
}
