// Задайте массив заполненный случайными положительными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

int [] array = GetArray(10, 100, 999);
Console.WriteLine($"[{string.Join(",", array)}]");

int evenNum = 0;

foreach(int el in array)
{
    evenNum += el % 2 == 0 ? 1 : 0;
}

Console.WriteLine($"Количество четных элементов в массиве: {evenNum}");

int[] GetArray(int size, int minValue, int maxValue)
{
    int[] result = new int[size];
    for(int i = 0; i < size; i++)
    {
        result[i] = new Random().Next(minValue, maxValue + 1);
    }
    return result;
}   