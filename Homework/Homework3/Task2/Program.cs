// See https://aka.ms/new-console-template for more information

// Напишите программу, которая принимает на вход координаты двух 
// точек и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53

int ReadInt(string message)
{
    Console.Write($"{message} > ");
    int value = int.Parse(Console.ReadLine());
    return value;
}

double getDistance(int x, int y, int z ){
    double temp = x * x + y * y + z*z;
    return Math.Sqrt(temp);
}


int x1 = ReadInt("Введите координату X1");
int y1 = ReadInt("Введите координату Y1");
int z1 = ReadInt("Введите координату Z1");
int x2 = ReadInt("Введите координату X2");
int y2 = ReadInt("Введите координату Y2");
int z2 = ReadInt("Введите координату Z2");


double Diag = getDistance(x1-x2, y1-y2, z1-z2);

System.Console.WriteLine($"Distance between 2 coordinates = {Diag}");