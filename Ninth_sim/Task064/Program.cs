// Задайте значение N. Напишите программу, которая выведет все натуральные числа 
// в промежутке от N до 1. Выполнить с помощью рекурсии.
// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"

Console.Write("Введите число N: ");
int n = int.Parse(Console.ReadLine()!);

Console.WriteLine($"{NaturalNumber(n, 1)}");

int NaturalNumber(int start, int end)
{
  if (start == end) return start;
  else Console.Write($"{NaturalNumber(start, end + 1)}, ");
  return end;
}







