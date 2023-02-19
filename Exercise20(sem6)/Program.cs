// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых,
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

using System;

Console.Clear();

Console.WriteLine("Введите число-значение b1:"); // 2
double b1 = double.Parse(Console.ReadLine());
Console.WriteLine("Введите число-значение k1:"); // 5
double k1 = double.Parse(Console.ReadLine());
Console.WriteLine("Введите число-значение b2:"); // 4
double b2 = double.Parse(Console.ReadLine());
Console.WriteLine("Введите число-значение k2:"); // 9
double k2 = double.Parse(Console.ReadLine());

double[] IntersectionPointOfLines(double b1, double k1, double b2, double k2)  // метод определения пересечения прямых
{ 
    double pointX = (b2 - b1) / (k1 - k2); //   x = 2/-4 = -0,5
    double pointY = k1 * pointX + b1; //   y = 5 * (-0,5) + 2 = -0,5
    double[] result = new double[2] {pointX, pointY};
    return result;
}

Console.WriteLine(String.Join("; ", IntersectionPointOfLines(b1, k1, b2, k2)));
