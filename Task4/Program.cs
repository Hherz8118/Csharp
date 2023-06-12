// See https://aka.ms/new-console-template for more information
// Напишите программу, которая на вход принимает число (N),
//  а на выходе показывает все чётные числа от 1 до N.
// 5 -> 2, 4
// 8 -> 2, 4, 6, 8
Console.WriteLine("Введито число N, для создания цифр от 1 до N ");

string input_string = Console.ReadLine();
int number = Convert.ToInt32(input_string);
Console.Write($"{number} -> ");
for (int i = 1; i < number; i++)
{
    if (i % 2 == 0){
    Console.Write($"{i}, ");
}
   
}
