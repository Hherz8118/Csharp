//Напишите программу, которая выводит случайное число из отрезка 
//[10, 99] и показывает наибольшую цифру числа.

// int ReadInt(string message)
// {
//     System.Console.Write(message);
//     int value = Convert.ToInt32(Console.ReadLine());
//     return value;
// }

// bool Validate3sign(int number)
// {
//     if (number >= 100 && number < 1000)
//     {
//         return true;
//     }

//     System.Console.WriteLine("Число не трехзначное");
//     return false;
// }

// int num = ReadInt("Введите число > ");
// if (Validate3sign(num))
// {
//     int lastDigit = num % 10;
//     System.Console.WriteLine($"Последняя цифра числа {num} равна {lastDigit}");
// }




//     int number = new Random().Next(10, 100); //создается рандомное число
//     System.Console.WriteLine($"Ваше число {number}"); // вывод рандомного числа
//     int a = number % 10; // цифру 1 до 9
//     int b = number/10; // десяток
//     if (a > b){
//         System.Console.WriteLine(a);
//     }
//     else {
//         System.Console.WriteLine(b);
//     }

// Напишите программу, которая будет принимать на вход два числа и выводить, является ли второе число кратным первому. Если число 2 не кратно числу 1, то программа выводит остаток от деления.
// 34, 5 -> не кратно, остаток 4 
// 16, 4 -> кратно



// int num = ReadInt("Введите число > ");



// if (Validate3sign(num))
// {
//     int lastDigit = num % 10; // 98/10 90 8
//         System.Console.WriteLine($"Последняя цифра числа {num} равна {lastDigit}");
// }
// if {
// int lastDigit = num % 98 // 9  98/10 % 10 

// }

// 2.1. Напишите программу, которая выводит случайное число из отрезка 
// [10, 9999] и показывает наибольшую цифру числа.
// 7812 -> 8 
// 1213-> 3 
// // 845 -> 8

// int number = new Random().Next(10, 9999) //6789
// System.Console.WriteLine($"Ваше число {number}");
//     int a = number % 10;   // единицы    9
//     int b = number /10 % 10; //десятки 6789/10 = 678,9 %10 67,89
//     int c = number /100 % 10; // сотни 6789/100 = 67,89 %10 6,789
//     int d = number /1000; // тысячи 
//     int max = a;
//     int[] Array = new int {a,b,c,d};
   

   int MaxDigit(int number)
{
    int max = 0;
    while(number > 0)
    {
        int rest10 = number % 10;
        if (rest10 > max)
        {
            max = rest10;
        }
        number /= 10;
    }
    return max;
}

int number = new Random().Next(10,10000);
int maxDigit = MaxDigit(number);
System.Console.WriteLine($"{number} -> {maxDigit}");