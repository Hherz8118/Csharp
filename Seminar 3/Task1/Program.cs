// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");

//Задача 2: Напишите программу, которая по заданному номеру четверти, показывает диапазон возможных координат точек в этой четверти (x и y).

int ReadInt(string message)
{
    Console.Write($"{message} > ");
    int value = int.Parse(Console.ReadLine());
    return value;
}

bool ValidateCoords(int x, int y)
{
    if (x == 0 || y == 0)
    {
        Console.WriteLine("Одна из координат равна нулю");
        return false;
    }
    return true;
}

int GetQuorterNumber(int x, int y)
{
    if (x > 0 && y > 0)
    {
        return 1;
    }
    if (x < 0 && y > 0)
    {
        return 2;
    }
    if (x < 0 && y < 0)
    {
        return 3;
    }
    return 4;
}

int x = ReadInt("Введите координату X");
int y = ReadInt("Введите координату Y");
if (ValidateCoords(x, y))
{
    int quorter = GetQuorterNumber(x, y);
    System.Console.WriteLine($"Номер четверти {quorter}");
}
