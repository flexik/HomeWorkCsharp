/* 
Задача 13 (#2): Напишите программу, которая выводит третью цифру заданного числа или сообщает,
что третьей цифры нет.
645 -> 5
78 -> третьей цифры нет
32679 -> 6
*/
using System;

Console.Write("Введите число: ");
string x = Console.ReadLine();
int index = 2;
int minLength = 3;

if (x.Length < minLength)
{
    Console.Write("Третьей цифры нет, введено не верное число -  повторите попытку");
}
else
{
    char secondChar = x[index];
    Console.Write($"Третья цифра : {secondChar}");
}
