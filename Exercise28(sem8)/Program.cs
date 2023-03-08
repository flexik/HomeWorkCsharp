// Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07


Console.Clear();
int[,] mainArray = GetArray(4);
System.Console.WriteLine();
System.Console.WriteLine("Спиральный массив 4 на 4: ");
PrintArray(mainArray);

int[,] GetArray(int length) // функция которая создает и возвращает спиральный массив
{
    int[,] array = new int[length, length];
    int row = 0;
    int column = 0;
    int dx = 1;
    int dy = 0;
    int dirChanges = 0;
    int visits = length;
    for (int i = 0; i < array.Length; i++)
    {
        array[row, column] = i + 1;
        if (--visits == 0)
        {
            visits =
                length * (dirChanges % 2)
                + length * ((dirChanges + 1) % 2)
                - (dirChanges / 2 - 1)
                - 2;
            int temp = dx;
            dx = -dy;
            dy = temp;
            dirChanges++;
        }
        column += dx;
        row += dy;
    }
    return array;
}

void PrintArray(int[,] array2D) // метод для выведения массива на экран
{
    for (int i = 0; i < array2D.GetLength(0); i++)
    {
        for (int j = 0; j < array2D.GetLength(1); j++)
        {
            System.Console.Write($"{array2D[i, j]} ");
        }
        System.Console.WriteLine();
    }
}
