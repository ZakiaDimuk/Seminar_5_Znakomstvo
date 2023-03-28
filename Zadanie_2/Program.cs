// Задача 2: Задайте одномерный массив, заполненный случайными числами. 
// Найдите сумму элементов, стоящих на нечётных индексах.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

int[] array = GetRandomArray(7, 0, 99);
Console.WriteLine($"[{String.Join(",",array)}]");

int sum = 0;
int i = 1;
while(i < array.Length)
{
    sum = sum + array[i];
    i = i + 2;
}
Console.WriteLine($"Сумма = {sum}");
// -------------------------------Общий метод-------------------------------------------
int[] GetRandomArray(int size, int minValue, int maxValue)
{
    int[] result = new int[size];
    for (int i = 0; i < size; i++)
    {
        result[i] = new Random().Next(minValue, maxValue + 1);
    }
    return result;
}