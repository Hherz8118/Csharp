// See https://aka.ms/new-console-template for more information


// See https://aka.ms/new-console-template for more information
// Напишите программу, которая принимает на вход цифру, 
// обозначающую день недели, и проверяет, является ли этот день выходным.
// 6 -> да
// 7 -> да
// 1 -> нет



Console.WriteLine("Введите номер дня недели (1-7):");
int dayNumber = int.Parse(Console.ReadLine());

bool isWeekend = IsWeekend(dayNumber);

if (isWeekend)
{
    Console.WriteLine("День является выходным.");
}
else
{
    Console.WriteLine("День не является выходным.");
}


static bool IsWeekend(int dayNumber)
{
    // Проверяем, является ли день выходным (суббота или воскресенье)
    if (dayNumber == 6 || dayNumber == 7)
    {
        return true;
    }

    return false;
}

