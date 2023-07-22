// Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.

// 0, 7, 8, -2, -2 -> 2
// -1, -7, 567, 89, 223-> 3

// int[] GetArray(string[] arr)
// {
//     int size = arr.Length;
//     int[] array = new int[size];
//     for (int i = 0; i < size; i++)
//     {
//         array[i] = int.Parse(arr[i]);
//     }
//     return array;
// }

// void PosNumber(int[] array)
// {
//     int result = 0;
//     for (int i = 0; i < array.Length; i++)
//     {
//         if (array[i] > 0) result++;
//     }
//     Console.Write($"Пользователь ввел M = {result} больше 0.");
// }

// Console.Write("Введите через запятую числа, которые будут добавлены в массив: ");

// string[] arr = Console.ReadLine()!.Split(',');
// int[] array = GetArray(arr);
// PosNumber(array);

using System.Runtime.ConstrainedExecution;

int Prompt(string message)
{
    Console.Write(message);
    return int.Parse(Console.ReadLine());
}

int[] InputArray(int size)
{
    int[] array = new int[size];
    for (int i = 0; i < size; i++)
        array[i] = Prompt($"Введите {i + 1}-й элемент: ");
    return array;
}

// void PrintArray(int[] array)
// {
//     for (int i = 0; i < array.Length; i++)
//     {
//         Console.WriteLine($"a[{i}] = {array[i]}");
//     }
// }

int CountPositiveNumbers(int[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > 0) count++;
    }
    return count;
}

int number = Prompt("Введите количество элементов: ");
int[] array = InputArray(number);
// PrintArray(array);
Console.WriteLine(string.Join(", ", array));
Console.WriteLine($"Количество чисел больше 0: {CountPositiveNumbers(array)}");