// See https://aka.ms/new-console-template for more information
// Напишите программу, которая на вход принимает число и выдаёт, 
// является ли число чётным (делится ли оно на два без остатка).
// 4 -> да
// -3 -> нет
// 7 -> нет

Console.WriteLine("Введите любое число: ");
string inputedNumber = Console.ReadLine();
int number = Convert.ToInt32(inputedNumber);

if (number % 2 == 0) {
Console.WriteLine($"{number} -> да");
}
else {
Console.WriteLine($"{number} -> нет");
}