// Задача 2 (№1)
Console.Clear();
Console.WriteLine("Напишите первое число");
int number1 = int.Parse(Console.ReadLine());
Console.WriteLine("Напишите второе число");
int number2 = int.Parse(Console.ReadLine());

if (number1 == number2) {
    Console.WriteLine($"Числа равны, запустите программу и введите числа заново");
    return;
}
if (number2 < number1) {
    Console.WriteLine($"Первое число: {number1} больше второго: {number2}");
}
if (number1 < number2) {
    Console.WriteLine($"Второе число: {number2} больше первого: {number1}");
}
