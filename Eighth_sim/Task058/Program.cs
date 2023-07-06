// Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

Console.WriteLine($"\nВведите размеры матриц и диапазон случайных значений:");

Console.Write("Введите число строк 1-й матрицы: ");
int m = int.Parse(Console.ReadLine()!);

Console.Write("Введите число столбцов 1-й матрицы (и строк 2-й): ");
int n = int.Parse(Console.ReadLine()!);

Console.Write("Введите число столбцов 2-й матрицы: ");
int p = int.Parse(Console.ReadLine()!);

Console.Write("Введите диапазон: от 1 до ");
int range = int.Parse(Console.ReadLine()!);

int[,] firstMatrix = new int[m, n];
GetArray(firstMatrix);
Console.WriteLine($"\nПервая матрица:");
PrintArray(firstMatrix);

int[,] secondMatrix = new int[n, p];
GetArray(secondMatrix);
Console.WriteLine($"\nВторая матрица:");
PrintArray(secondMatrix);

int[,] resultMatrix = new int[m,p];

MultiplyMatrix(firstMatrix, secondMatrix, resultMatrix);
Console.WriteLine($"\nПроизведение первой и второй матриц:");
PrintArray(resultMatrix);

void MultiplyMatrix(int[,] firstMatrix, int[,] secondMatrix, int[,] resultMatrix)
{
  for (int i = 0; i < resultMatrix.GetLength(0); i++)
  {
    for (int j = 0; j < resultMatrix.GetLength(1); j++)
    {
      int sum = 0;
      for (int k = 0; k < firstMatrix.GetLength(1); k++)
      {
        sum += firstMatrix[i,k] * secondMatrix[k,j];
      }
      resultMatrix[i,j] = sum;
    }
  }
}

void GetArray(int[,] array)
{
  for (int i = 0; i < array.GetLength(0); i++)
  {
    for (int j = 0; j < array.GetLength(1); j++)
    {
      array[i, j] = new Random().Next(range);
    }
  }
}

void PrintArray (int[,] array)
{
  for (int i = 0; i < array.GetLength(0); i++)
  {
    for (int j = 0; j < array.GetLength(1); j++)
    {
      Console.Write(array[i,j] + " ");
    }
    Console.WriteLine();
  }
}