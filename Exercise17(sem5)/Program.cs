// Задача 36: Задайте одномерный массив,
// заполненный случайными числами. 
// Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

using System;
Console.Clear();

Console.WriteLine("Напишите нужный размер массива:");
int size = int.Parse(Console.ReadLine());

int[] GetArray(int size){   // метод возвращающий массив c кол-вом элементов, заданных пользователем, заполненный случайными числами от -100 до 100
    int[] result = new int[size];
    for (int i = 0; i < size; i++)
    {
        result[i] = new Random().Next(-100, 100);
    }
    return result;
}

int[] Array = GetArray(size);
Console.WriteLine(String.Join(", ", Array));


int CountUnevenElements(int[] array){           // метод возвращающий сумму элементов, стоящих на нечётных позициях.
    int result = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (i % 2 == 1)
        {
            result += array[i];
        }
    }
    return result;
}

Console.WriteLine($"Сумма элементов, стоящих на нечётных позициях: {CountUnevenElements(Array)}");





