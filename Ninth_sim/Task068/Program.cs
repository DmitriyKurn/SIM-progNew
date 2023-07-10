// Напишите программу вычисления функции Аккермана с помощью рекурсии. 
// Даны два неотрицательных числа m и n. Выполнить с помощью рекурсии.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29

Console.Write("Введите число M: ");
int m = int.Parse(Console.ReadLine()!);

Console.Write("Введите число N: ");
int n = int.Parse(Console.ReadLine()!);

Console.WriteLine($"A({m},{n}) = {Akkerman(m, n)}");

int Akkerman(int start, int end)
{
  if (start == 0) return end + 1;
  if (m > 0 && end == 0) return Akkerman(start - 1, 1);
  else return Akkerman(start - 1, Akkerman(start, end - 1));
}




