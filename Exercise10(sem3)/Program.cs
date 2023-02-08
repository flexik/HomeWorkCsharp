// Задача 23 (#3)
// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125

using System;

Console.Clear();

Console.Write("Введите число N: ");
int N = int.Parse(Console.ReadLine());
int i = 1;

// if (N < 0){
//     i = N;
//     N = -1;
// }
int[] result = new int[N];
for (int j = 0; j < N; j++)
{
    result[j] = j * j * j;
}
for (int j = 0; j < N; j++)
{
    Console.Write($"{result[j]} ");
}