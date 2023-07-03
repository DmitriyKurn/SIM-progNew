// Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
// и возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// i = 1, j = 2 -> 2
// i = 4, j = 2 -> такого элемента не существует

Console.Write("введите номер строки: ");
int n = int.Parse(Console.ReadLine());

Console.Write("введите номер столбца: ");
int m = int.Parse(Console.ReadLine());
int [,] array = new int [5,5];
GetArray(array);


if (n > array.GetLength(0) || m > array.GetLength(1))
{
    Console.WriteLine("Такого элемента не существует");
}
else
{
    Console.WriteLine($"значение элемента строки {n} и столбца {m} равно {array[n,m]}");
}

PrintArray(array);

void GetArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
        {        
            for (int j = 0; j < array.GetLength(1); j++)
            {
                array [i,j] = new Random().Next(-100, 100);
            }   
        }
}

void PrintArray(int[,] inarray)
{
    for (int i = 0; i < inarray.GetLength(0); i++)
    {
        for (int j = 0; j < inarray.GetLength(1); j++)
        {
            Console.Write($"{inarray[i,j]} ");
        }
        Console.WriteLine();
    }
}
