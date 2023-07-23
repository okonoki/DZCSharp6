// Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.

// 0, 7, 8, -2, -2 -> 2
// -1, -7, 567, 89, 223-> 3

int[] GetArray(string[] arr)
{
    int size = arr.Length;
    int[] array = new int[size];
    for (int i = 0; i < size; i++)
    {
        array[i] = int.Parse(arr[i]);
    }
    return array;
}

void PosNumber(int[] array)
{
    int result = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > 0) result++;
    }
    Console.Write($"Пользователь ввел M = {result} больше 0.");
}

Console.Write("Введите через запятую числа, которые будут добавлены в массив: ");

string[] arr = Console.ReadLine()!.Split(',');
int[] array = GetArray(arr);
Console.Write("[");
Console.Write(string.Join(", ", array));
Console.Write("]");
Console.WriteLine("");
PosNumber(array);