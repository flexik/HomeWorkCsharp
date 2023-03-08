// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка

int[,] mas = new int[4, 4] { { 1, 4, 7, 2 }, { 5, 9, 2, 3 }, { 8, 4, 2, 4 }, { 5, 2, 6, 7 } }; // создал двумерный массив
PrintArray(mas);
Console.WriteLine();

void findRowWithMinSum(int[,] array)
{ // метод нахождения строки с нименьшей суммой элементов
    int sumRow = 0; // переменная для записи суммы каждой строки
    int minSum = 2147483647;
    int index = 0; // индекс для выбора минимальной суммы из rawSumArray

    int[] rawSumArray = new int[array.GetLength(0)]; // массив, где хранятся все суммы строк двумерного массива
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            sumRow = sumRow + array[i, j];
        }
        Console.WriteLine("Сумма " + (i + 1) + " строки: " + sumRow);
        if (sumRow < minSum)
        {
            index = i + 1;
            minSum = sumRow;
        }
        rawSumArray[i] = sumRow;
        sumRow = 0;
    }
        Console.WriteLine();
        System.Console.WriteLine($"Строка {index} имеет наименьшую сумму элементов, равную {minSum}");
}

void PrintArray(int[,] array) // Функция вывода двумерного массива
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j]} ");
        }
        Console.WriteLine();
    }
}

findRowWithMinSum(mas);
