﻿/* 
Задача 15 (#3): Напишите программу, которая принимает на вход цифру, обозначающую день недели, 
и проверяет, является ли этот день выходным.
6 -> да
7 -> да
1 -> нет
*/
using System;

Console.Write("Введите день недели от 1 до 7: ");
int x = int.Parse(Console.ReadLine());

if (x < 1 || x > 7)
{
    Console.Write("Необходимо ввести число от 1 до 7 - повторите попытку");
}
else if (x <= 5)
{
    Console.Write("Нет - данный день недели рабочий");
}
else 
{
    Console.Write("Да - данный день недели выходной");
}