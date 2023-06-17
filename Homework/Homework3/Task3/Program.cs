// See https://aka.ms/new-console-template for more information
// Напишите программу, которая принимает на вход число 
// (N) и выдаёт таблицу кубов чисел от 1 до N.
// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125

int ReadInt(string message)
{
    Console.Write(message);
    int value = int.Parse(Console.ReadLine());
    return value;
}

int number = ReadInt("Введите целое положительное число > ");
int x = 1; 

while (x <= number)
{
    int result = x*x*x;
    Console.Write($"{result} ");
    x++;
}
Console.WriteLine();
