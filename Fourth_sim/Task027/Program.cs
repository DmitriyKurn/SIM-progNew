// Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

Console.Write("Введите число: ");
int N = int.Parse(Console.ReadLine()!);

Console.WriteLine($"Сумма цифр в числе -> {Sumdigits(N)}");

int Sumdigits(int sum)
{
    int counter = Convert.ToString(N).Length;
    int advance = 0;
    int result = 0;
    for (int i = 0; i < counter; i++)
    {
        advance = N - N % 10;
        result = result + (N - advance);
        N = N / 10;
    }
    return result;
}


