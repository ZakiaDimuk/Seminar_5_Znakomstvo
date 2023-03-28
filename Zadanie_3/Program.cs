// Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
// (https://learn.microsoft.com/ru-ru/dotnet/api/system.random.nextdouble?view=net-7.0)

// [3, 7.4, 22.3, 2, 78] -> 76

double[] array = GetRandomArray(5);
Console.WriteLine($"[{String.Join("; ", array)}]");

double min = array[0];
double max = array[0];

int i = 1;

while (i < array.Length)
{
    if (max < array[i]) max = array[i];
    if (min > array[i]) min = array[i];
    i++;
}
Console.WriteLine($"Max = {max}");
Console.WriteLine($"Min = {min}");
Console.WriteLine($"Разница между Max и Min = {Math.Round(max-min,3)}");

// -------------------------------Общий метод-------------------------------------------
double[] GetRandomArray(int size)
{
    double[] result = new double[size];
    Random rnd = new Random();
    for (int i = 0; i < result.Length; i++)
    {
        result[i] = Math.Round(rnd.NextDouble() * 100 + 1,3);
    }
    return result;
}