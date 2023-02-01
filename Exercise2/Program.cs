// Задача 4 (№2) Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
using System;

Console.Clear();
Console.WriteLine("Напишите первое число");
int number1 = int.Parse(Console.ReadLine());
Console.WriteLine("Напишите второе число");
int number2 = int.Parse(Console.ReadLine());
Console.WriteLine("Напишите третье число");
int number3 = int.Parse(Console.ReadLine());

if (number1 > number2 & number1 > number3){
    Console.WriteLine($"Максимальное число: {number1}");
}
if (number2 > number1 & number2 > number3){
    Console.WriteLine($"Максимальное число: {number2}");
}
if (number3 > number1 & number3 > number2){
    Console.WriteLine($"Максимальное число: {number3}");
}
else
{
    Console.WriteLine($"Вы ввели одинаковые числа - запустите программу и введите числа заново");
    return;
}