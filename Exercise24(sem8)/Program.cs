// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по возрастанию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2

int[,] mas = new int[3, 4] { { 1, 4, 7, 2 }, { 5, 9, 2, 3 }, { 8, 4, 2, 4 } }; // создал двумерный массив
PrintArray(mas);
int bufer;

Console.WriteLine();

void AcendingNumbers(int[,] array)          // Функция вывода двумерного массива
{
    for (int i = 0; i < array.GetLength(0); i++)    // итерация по строкам
    {
        for (int j = 0; j < array.GetLength(1); j++)   // итерация по столбцам
        {
            for (int k = 0; k < array.GetLength(1) - j - 1; k++)  // итерация для сравнения и замены
            {
                if (array[i, k] > array[i, k + 1])
                {
                    bufer = array[i, k];     // замена элементов
                    array[i, k] = array[i, k + 1];
                    array[i, k + 1] = bufer;
                }
            }
        }
    }
}

AcendingNumbers(mas);

void PrintArray(int[,] array)   // Функция вывода двумерного массива
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

PrintArray(mas);