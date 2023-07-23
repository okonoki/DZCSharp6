// Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.

// 0, 7, 8, -2, -2 -> 2
// -1, -7, 567, 89, 223-> 3

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

void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.WriteLine($"a[{i}] = {array[i]}");
    }
}

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
PrintArray(array);
Console.WriteLine($"Количество чисел больше 0: {CountPositiveNumbers(array)}");