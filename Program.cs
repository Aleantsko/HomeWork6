// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3

// int[] EnterNumbers(string text = "Введите числа через запятую: ")
// {
//     System.Console.Write("Введите числа через запятую: ");
//     return Array.ConvertAll(Console.ReadLine()!.Split(","), int.Parse);
// }

// void PrintArray(int[] array)
// {
//     System.Console.WriteLine(String.Join(",", array));

// }

// int CountMoreZero(int[] array)
// {
//     int sum = 0;

//     for (int i = 0; i < array.Length; i++)
//     {
//         if (array[i] > 0) sum++;
//     }
//     return sum;
// }

// Console.Clear();
// int[] array = EnterNumbers();
// PrintArray(array);
// System.Console.WriteLine($"Колличество значений больше 0 равна {CountMoreZero(array)}");


// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями 
// y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

double EnterNumber(string name)
{
    System.Console.Write($"Введите {name}:");
    return Convert.ToDouble(Console.ReadLine());
}

double CalcX(double b2, double b1, double k1, double k2)
{
    double calc = 0;
    calc = -(b1 - b2) / (k1 - k2);
    return calc;
}

double CalcY(double k1, double x, double b1)
{
    double calc = 0;
    calc = k1 * x + b1;
    return calc;
}

Console.Clear();
double b1 = EnterNumber("b1");
double k1 = EnterNumber("k1");
double b2 = EnterNumber("b2");
double k2 = EnterNumber("k2");


Console.WriteLine($"Пересечение в точке: ({CalcX(b2, b1, k1, k2)};{CalcY(k1, CalcX(b2, b1, k1, k2), b1)})");