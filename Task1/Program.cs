// See https://aka.ms/new-console-template for more information
// Напишите программу, которая на вход принимает два числа и выдаёт,
//  какое число большее, а какое меньшее.
// a = 5; b = 7 -> max = 7
// a = 2 b = 10 -> max = 10
// a = -9 b = -3 -> max = -3
Console.WriteLine("Введите первое число 'a'");
string input_string1 = Console.ReadLine();
Console.WriteLine("Введите первое число 'b'");
string input_string2 = Console.ReadLine();
int number1 = Convert.ToInt32(input_string1);
int number2 = Convert.ToInt32(input_string2);
int max = number1;
if (number1>number2){
    max = number1;
    Console.WriteLine($"max = {max}");
    }
else {
    max = number2;
    Console.WriteLine($"max = {max}");
}