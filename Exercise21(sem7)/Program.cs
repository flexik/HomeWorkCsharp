// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9

Console.Clear();

Console.WriteLine("Введите количество строк массива: ");
int m = int.Parse(Console.ReadLine());
Console.WriteLine("Введите количество столбцов массива: ");
int n = int.Parse(Console.ReadLine());
Console.WriteLine("Введите минимальное возможное вещественное число массива: ");
double min = int.Parse(Console.ReadLine());
Console.WriteLine("Введите максимальное возможное вещественное число массива: ");
double max = int.Parse(Console.ReadLine());

double[,] array = GetDoubleArray(m, n, min, max);
PrintArray(array);

double[,] GetDoubleArray(int rows, int columns, double minValue, double maxValue)    // метод создания двумерного массива со случайными вещественными числами
{
    double[,] result = new double[rows, columns];
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            result[i, j] = Math.Round(
                (new Random().NextDouble() * (maxValue - minValue)) + minValue,
                1
            );
        }
    }
    return result;
}

void PrintArray(double[,] inArray) // метод вывода двумерного массива на экран
{
    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        for (int j = 0; j < inArray.GetLength(1); j++)
        {
            System.Console.Write($"{inArray[i, j]} ");
        }
        System.Console.WriteLine();
    }
}
