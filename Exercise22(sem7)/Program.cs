// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве,
// и возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет

Console.Clear();

Console.Write("Введите строку искомого элемента:");
int pos1 = Convert.ToInt32(Console.ReadLine()) - 1;
Console.Write("Введите столбец искомого элемента:");
int pos2 = Convert.ToInt32(Console.ReadLine()) - 1;

int n = 3; // размер массива
int m = 4; // размер массива
Random random = new Random();
int[,] arr = new int[n, m];
Console.WriteLine("Исходный массив:");
for (int i = 0; i < arr.GetLength(0); i++)
{
    for (int j = 0; j < arr.GetLength(1); j++)
    {
        arr[i, j] = random.Next(1, 10);
        Console.Write("{0} ", arr[i, j]);
    }
    Console.WriteLine();
}

bool FindElementByIndex(int[,] array) // метод возвращающий true или false
{
    return (pos1 < 0 | pos1 > arr.GetLength(0) - 1 | pos2 < 0 | pos2 > arr.GetLength(1) - 1);
}

if (FindElementByIndex(arr)) // если метод вернет true от наших 2 чисел, то элемент не существует, если false то - значение элемента вывести
{
    Console.WriteLine("Элемент не существует");
}
else
{
    Console.WriteLine("Значение элемента массива = {0}", arr[pos1, pos2]);
}
