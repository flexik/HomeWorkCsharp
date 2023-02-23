// Задача 38: Задайте массив вещественных чисел.
// Найдите разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76

using System;

Console.Clear();

Console.WriteLine("Напишите нужный размер массива:");
int size = int.Parse(Console.ReadLine());

int[] GetArray(int size)
{ // метод возвращающий массив c кол-вом элементов, заданных пользователем, заполненный случайными числами от -100 до 100
    int[] result = new int[size];
    for (int i = 0; i < size; i++)
    {
        result[i] = new Random().Next(-100, 100);
    }
    return result;
}

int[] Array = GetArray(size);
Console.WriteLine(String.Join(", ", Array));

int DifferenceBetweenMaxMin(int[] array)
{ // метод возвращающий разницу между минимальным и максимальным значениями массива
    int MinValue = 0;
    int MaxValue = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > MaxValue)
        {
            MaxValue = array[i];
        }
        else if (array[i] < MinValue)
        {
            MinValue = array[i];
        }
    }
    return (MaxValue - MinValue);
}

Console.WriteLine(
    $"Разница между максимальным значением и минимальным: {DifferenceBetweenMaxMin(Array)}"
);
