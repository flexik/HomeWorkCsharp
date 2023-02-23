// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

int[,] mas = new int[3,4] {{1,4,7,2},{5,9,2,3},{8,4,2,4}};        // создал необходимый массив

void PrintArray(int[,] inArray)                               // метод записи массива для вывода на экран
{
    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        for (int j = 0; j < inArray.GetLength(1); j++)
        {
            Console.Write($"{inArray[i,j]} ");
        }
        Console.WriteLine();
    }
}

PrintArray(mas);      // вывод масссива на экран

void MeanArifmeticOfColumns(){                  // метод, считающий среднее арифметическое по каждому из столбцов
            for (int i = 0; i < 4; i++) 
            {
                int srAr = 0;
                for (int t = 0; t < 3; t++)
                {
                    srAr += mas[t, i];
                }
                Console.WriteLine($"Cреднее арифметическое элементов столбца {i + 1} = {(float)srAr/3, 1:f1}");
            }
}

MeanArifmeticOfColumns();