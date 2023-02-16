// Урок 5. Функции и одномерные массивы
// Доп
// Задача 35:Задайте одномерный массив из 123 случайных чисел [0: 1000].
// Найдите количество элементов массива, значения которых лежат в отрезке [10,99].
// Пример для массива из 5, а не 123 элементов. В своём решении сделайте для 123
// [5, 18, 123, 6, 2] -> 1
// [1, 2, 3, 6, 2]-> 0
// [10, 11, 12, 13, 14]-> 5

using System;
Console.Clear();

int[] GetArray(int size, int min, int max){          // создал метод возвращающий заданный массив
    int[] result = new int[size];
    for (int i = 0; i < size; i++)
    {
        result[i] = new Random().Next(min, max + 1);
    }
    return result;
}

int[] Array1 = GetArray(123, 0, 1000);
Console.WriteLine(String.Join(", ", Array1));



int CountElements(int[] Array, int minValue, int maxValue){                  // создал метод возвращающий количество элементов массива в заданном промежутке
    int count = 0;
    for (int i = 0; i < Array.Length; i++){
        if (Array[i] >= minValue && Array[i] <= maxValue)
        {
            count++;
        }
    }
    return count;
}

Console.WriteLine($"Количество элементов в промежутке от 10 до 99: {CountElements(Array1, 10, 99)}");
