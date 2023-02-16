// Доп
// Задача 37:Найдите произведение пар чисел в одномерном массиве.
// Парой считаем первый и последний элемент, второй и предпоследний и т.д.
// Результат запишите в новом массиве.
// [1 2 3 4 5] -> 5 8 3
// [6 7 3 6]-> 36 21


Console.Clear();
Console.Write("Введите элементы массива через пробел: ");   // ввод строки чисел с клавиатуры
string elements = Console.ReadLine();

int[] baseArray = GetArrayFromString(elements);   // записал в массив числа из строки, которые ввел пользователь

int[] GetArrayFromString(string stringArray)   // метод преобразования из строки в массив
{
string[] nums = stringArray.Split(" ", StringSplitOptions.RemoveEmptyEntries);
int[] res = new int[nums.Length];

for (int i = 0; i < nums.Length; i++)
{
res[i] = int.Parse(nums[i]);
}
return res;
}

var str = String.Join(", ", baseArray);    // проверка на то, что верно записал массив
Console.WriteLine($"{str}");

int[] IncreaseArrayElements(int[] Array){        // метод записыващий произведение пар чисел в новый массив
    int size = (Array.Length+1)/2;
    int[] result = new int[size];
    for (int i = 0; i < Array.Length/2; i++)
    {
        result[i] = Array[i] * Array[Array.Length - i - 1];
    }
    if (Array.Length%2 == 1) result[size-1] = Array[Array.Length/2];
    return result;
}

Console.WriteLine(String.Join(", ", IncreaseArrayElements(baseArray)));
