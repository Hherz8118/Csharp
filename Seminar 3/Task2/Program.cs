// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");

// Напишите программу, которая принимает на вход координаты точки 
// (X и Y), причём X ≠ 0 или Y ≠ 0 и выдаёт номер четверти плоскости,
// в которой находится эта точка.

int ReadInt(string message)
{
    System.Console.WriteLine($"{message} >");
    int value = int.Parse(Console.ReadLine());
    return value;
}

bool VaidateCords(int x)
{
    if (x <= 0 || x > 4)
    {
        System.Console.WriteLine("Вы ввели значение равной 0");
        return false;
    }
    return true;
}

string GetQuorterNumber(int x)
{
    string message = "";
    if (x == 1)
    {
        message = "Диапазон первой четверти от 1 до N по X и от 1 до N по Y";
    }
    if (x == 2)
    {
        message = "Диапазон первой четверти от -1 до -N по X и от 1 до N по Y";
    }
    if (x == 3)
    {
        message = "Диапазон первой четверти от -1 до -N по X и от -1 до -N по Y";
    }
    if (x == 4)
    {
        message = "Диапазон первой четверти от 1 до N по X и от -1 до -N по Y";
    }

    return message;
}

int x = ReadInt("Введите координату Х ");

if (VaidateCords(x))
{
    System.Console.WriteLine($"{GetQuorterNumber(x)}");
}


// Или 
// System.Console.WriteLine("Укажите четверть ");

// static void DeterminadeDiapozon(int GetQuorterNumber)
// {
//     switch (GetQuorterNumber)
//     {
//         case 1:
//             System.Console.WriteLine("Первая четверть, диапозон x равен 1 - до бесконечности, y равен 1 - до бесконечности ");
//             break;
//         case 2:
//             System.Console.WriteLine(" Вторая четверть, диапозон x равен -1 - (-до бесконечности), y равен 1 - до бесконечности ");
//             break;
//         case 3:
//             System.Console.WriteLine("Третья четверть, диапозон x равен -1 - (-до бесконечности), y равен -1 - (-до бесконечности) ");
//             break;
//         case 4:
//             System.Console.WriteLine("Четвертая четверть, диапозон x равен 1 - до бесконечности, y равен -1 - (-до бесконечности) ");
//             break;
//     }
   
// }
// string quorter = Console.ReadLine();
// int GetQuorterNumber = Convert.ToInt32(quorter);

// bool ValidateCoords(int GetQuorterNumber)
// {
//     if (GetQuorterNumber > 0 && GetQuorterNumber <= 4)
//     {
//         return true;
//     }
//     System.Console.WriteLine("Такой четверти нет ");
//     return false;
// }

// if (ValidateCoords(GetQuorterNumber))
// {
//     DeterminadeDiapozon(GetQuorterNumber);

// }