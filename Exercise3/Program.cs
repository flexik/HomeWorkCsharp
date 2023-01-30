// Задача 6 (№3)Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).
Console.Clear();
Console.WriteLine("Напишите натуральное число для проверки на чётность");
int number = int.Parse(Console.ReadLine());

if (number == 0 || number < 0)
{
    Console.WriteLine("Вы ввели 0 или отрицательное число - запустите программу заново и повторите попытку");
    return;
}
if (number % 2 == 0){
    Console.WriteLine($"Число {number} является чётным");
}
if (number % 2 == 1){
    Console.WriteLine($"Число {number} является нечётным");
}