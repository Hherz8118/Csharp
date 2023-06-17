// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");

// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 2D пространстве.

int ReadInt(string message)
{
    Console.Write($"{message} > ");
    int value = int.Parse(Console.ReadLine());
    return value;
}

double getDistance(int x, int y ){
    double temp = x * x + y * y;
    return Math.Sqrt(temp);
}


int x1 = ReadInt("Введите координату X1");
int y1 = ReadInt("Введите координату Y1");
int x2 = ReadInt("Введите координату X2");
int y2 = ReadInt("Введите координату Y2");

double Diag = getDistance(x1-x2, y1-y2);

System.Console.WriteLine($"Distance between 2 coordinates = {Diag}");
