// Задача 8 (#4): Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
using System;

Console.Clear();
Console.WriteLine("Напишите число");
int N = int.Parse(Console.ReadLine());
int count = 1;

while(count <= N){
    if (count % 2 == 0){
        Console.WriteLine($"{count}");
        count ++;
    }
    if (count % 2 == 1){
        count ++;
    }
    else
    {
        Console.WriteLine("Введите натуральное число и повторите попытку");
        break;
    }
}