// See https://aka.ms/new-console-template for more information

// Задача 2: Напишите программу, которая принимает на вход три числа и
//  выдаёт максимальное из этих чисел.
// 2, 3, 7 -> 7
// 44 5 78 -> 78
// 22 3 9 -> 22
int[] numbers = new int [3];
int length = numbers.Length;
 for (int i = 0; i < length; i++)
        {
            Console.Write($"Введите значение для элемента {i+1}: ");
            numbers[i] = int.Parse(Console.ReadLine());
        }
int max = numbers [0];
for (int i = 1; i < length; i++)
        {
            if (numbers[i]>max)
            {
                max = numbers[i];
            }
        }
Console.Write($"{numbers[0]},{numbers[1]},{numbers[2]} -> {max}"); 
