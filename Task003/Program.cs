// Напишите программу, которая принимает на вход число N и выдает произведение чисел от 1 до N.

int Count (int N)
{
    int result = 1;
    for (int number = 1; number <= N; number++)
    {
        result *= number;
    }
    return result;
}
Console.Write("Введите число N: ");
int N = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"Произведение чисел от 1 до {N} равно {Count(N)}");
