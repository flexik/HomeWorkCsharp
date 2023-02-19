// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3

using System;

Console.Clear();

Console.WriteLine("Введите целые числа через пробел:");
string elements = Console.ReadLine(); // получаем строку из элементов, которые ввёл юзер
int[] arrayFromUser = GetArrayFromString(elements); // помещаем элементы в массив с помощью метода преобразования из строки в массив
Console.WriteLine(String.Join(", ", FindPositiveElements(arrayFromUser))); // вывод результата метода, который определяет кол-во положительных чисел в массиве

int[] GetArrayFromString(string stringArray) // метод преобразования из строки в массив
{
    string[] nums = stringArray.Split(" ", StringSplitOptions.RemoveEmptyEntries);
    int[] result = new int[nums.Length];

    for (int i = 0; i < nums.Length; i++)
    {
        result[i] = int.Parse(nums[i]);
    }
    return result;
}

int FindPositiveElements(int[] array)
{ // метод, который считает кол-во положительных чисел в массиве
    int result = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > 0)
        {
            result++;
        }
    }
    return result;
}
