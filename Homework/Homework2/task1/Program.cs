// See https://aka.ms/new-console-template for more information
// Напишите программу, которая принимает на вход
//  трёхзначное число и на выходе показывает вторую цифру этого числа.
// 456 -> 5
// 782 -> 8
// 918 -> 1

Console.WriteLine("Введите целое число:");
int number = Convert.ToInt32(Console.ReadLine());
int a = number / 10 % 10; // 
if (number > 100 && number < 999)
{
    System.Console.WriteLine($"{number} -> {a}"); // вывод рандомного числа
}
else {
    System.Console.WriteLine("ERROR!");
}