// Задача 2 (№1) Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

Console.Clear();
Console.WriteLine("Напишите первое число");
int number1 = int.Parse(Console.ReadLine());
Console.WriteLine("Напишите второе число");
int number2 = int.Parse(Console.ReadLine());

if (number2 < number1){
    Console.WriteLine($"Первое число: {number1} больше второго: {number2}");
}
if (number1 < number2){
    Console.WriteLine($"Второе число: {number2} больше первого: {number1}");
}
else
{
    Console.WriteLine($"Числа {number1} и {number2} равны, запустите программу и введите числа заново");
    return;
}