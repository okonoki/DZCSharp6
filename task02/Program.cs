// Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2;
// значения b1, k1, b2 и k2 задаются пользователем.

// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

int Prompt(string message)
{
    Console.Write(message);
    return int.Parse(Console.ReadLine());
}

double[] GetArray(double b1, double k1, double b2, double k2)
{
    double[] array = new double[2];
    array[0] = (b2 - b1) / (k1 - k2);
    array[1] = k2 * array[0] + b2;
    return array;
}

double b1 = Prompt("Введите b1: ");
double k1 = Prompt("Введите k1: ");
double b2 = Prompt("Введите b2: ");
double k2 = Prompt("Введите k2: ");

double[] array = GetArray(b1, k1, b2, k2);
Console.WriteLine($"({string.Join("; ", array)})");