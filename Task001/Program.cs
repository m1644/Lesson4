// Напишите программу, которая принимает на вход число (А) и выдает сумму чисел от 1 до А.

int Sum(int A)
{
    int result = 0;
    for (int number = 0; number <= A; number++)
    {
        result += number; // result = result + number
    }
    return result;
}

void PrintSum(int A)
{
    Console.WriteLine($"Сумма чисел от 1 до {A} равна {Sum(A)}");
}
PrintSum(5);
PrintSum(10);
PrintSum(0);
PrintSum(-20);
