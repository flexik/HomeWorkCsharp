// Урок 9. Рекурсия
// Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.
// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"

int N = 5;

// int N = 8;

void AscendingRecursive(int n) // рекурсивный метод, который выведет все натуральные числа в промежутке от N до 1
{
    Console.WriteLine(n);
    if (n <= 1)
        return; // окончание рекурсии
    AscendingRecursive(n - 1);
}

AscendingRecursive(N);
