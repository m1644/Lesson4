// Напишите программу, которая принимает на вход число и выдает количество цифр в числе.

Console.Write("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());
int count = (int)Math.Log10(num) + 1;
Console.WriteLine($"Число состоит из {count} цифр.");

// Решение через цикл for

int Digits (int N)
{
    int result = 0;
    for (int number = N; number > 0; number /= 10)
    {
        result++;
    }
    return result;
}
void PrintDigits(int N)
{
    Console.WriteLine($"Количество цифр в числе {N} равна {Digits(N)}.");
}
PrintDigits(4);
PrintDigits(444);
PrintDigits(444444);
