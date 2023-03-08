// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

int[,] Array1 = { { 2, 4 }, { 3, 2 } };
int[,] Array2 = { { 3, 4 }, { 3, 3 } };

int qtyRowsOfArray1 = Array1.GetLength(0);
int qtyColumnsOfArray1 = Array1.GetLength(1);
int qtyColumnsOfArray2 = Array2.GetLength(1);

PrintArray(Array1);
Console.WriteLine();
PrintArray(Array2);

MultipleOfArrays(Array1, Array2);
Console.WriteLine("Произведение двух матриц :");
PrintArray(MultipleOfArrays(Array1, Array2));

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

int[,] MultipleOfArrays(int[,] array1, int[,] array2)
{
    int i, j;
    int[,] resultArray = new int[Array1.GetLength(0), Array2.GetLength(1)];
    for (i = 0; i < qtyRowsOfArray1; i++)
    {
        for (j = 0; j < qtyColumnsOfArray2; j++)
        {
            resultArray[i, j] = 0;
            for (int k = 0; k < qtyColumnsOfArray1; k++)
            {
                resultArray[i, j] += array1[i, k] * array2[k, j];
            }
        }
    }
    return resultArray;
}
