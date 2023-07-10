// Задайте значения M и N. Напишите программу, которая найдёт сумму 
// натуральных элементов в промежутке от M до N. Выполнить с помощью рекурсии.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

Console.Write("Введите число M: ");
int m = int.Parse(Console.ReadLine()!);

Console.Write("Введите число N: ");
int n = int.Parse(Console.ReadLine()!);

Console.WriteLine($"{SumElements(m, n)}"); 

int SumElements(int start, int end)
{
  if (start == end) return start;
  else return SumElements(start + 1, end) + start;
}



