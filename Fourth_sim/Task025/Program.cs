// Напишите цикл, который принимает на вход два числа (A и B) 
// и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

Console.Write("Введите число А: ");
int A = int.Parse(Console.ReadLine()!);

Console.Write("Введите число B: ");
int B = int.Parse(Console.ReadLine()!);

Console.WriteLine($"Число A в степени B -> {Exponentiation(A, B)}");

int Exponentiation(int X, int Y)
{
    int result = 1;
    for (int i = 1; i <= Y; i++)
    {
        result = result * X;
    }
    return result;

}





