// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

int M = 1; // задаю значение M и N
int N = 15;

SumFromMToN(M, N);

void SumFromMToN(int m, int n) // вызов функции "сумма чисел от M до N"
{
    Console.Write($"Сумма натуральных элементов в промежутке от M до N: {SumMN(m - 1, n)}");
}

int SumMN(int m, int n) // функция сумма чисел от M до N
{
    int res = m;
    if (m == n)
        return 0;
    else
    {
        m++;
        res = m + SumMN(m, n);
        return res;
    }
}

SumMN(M - 1, N);
