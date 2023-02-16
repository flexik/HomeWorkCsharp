// Задача 34: Задайте массив заполненный
// случайными положительными трёхзначными числами.
// Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

using System;
Console.Clear();

int[] GetArray(int size, int min, int max){   // метод возвращающий массив заполненный случайными положительными трёхзначными числами
    int[] result = new int[size];
    for (int i = 0; i < size; i++)
    {
        result[i] = new Random().Next(min, max);
    }
    return result;
}

int[] Array1 = GetArray(10, 100, 1000);
Console.WriteLine(String.Join(", ", Array1));

int EvenNumbers(int[] array){
    int qty = 0;
    foreach (var element in array){
        if (element % 2 == 0){
            qty++;
        }
        else{
            qty += 0;
        }
    }
    return qty;
}

Console.WriteLine($"Количество четных чисел в массиве: {EvenNumbers(Array1)}");