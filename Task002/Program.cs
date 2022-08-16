// Напишите программу, которая принимает на вход число и выдает количество цифр в числе.

Console.Write("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());
int count = (int)Math.Log10(num) + 1;
Console.WriteLine($"Число состоит из {count} цифр.");

// Решение через While

int Digits (int number)
{
    int N = number;
    int result = 1;
    while (N > 10)
    {
      N /= 10;
      result++;
    }
    return result;
}
void PrintDigits(int number)
{
    Console.WriteLine($"Число {number} содержит {Digits(number)} цифр.");
}
PrintDigits(4);
PrintDigits(444);
PrintDigits(4444);
