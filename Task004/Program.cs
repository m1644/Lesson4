// Напишите программу, которая выводит массив из 8 элементов, 
// заполненный нулями и единицами в случайном порядке.

int[] ArrayCreation(int length)
{
    int[] arr = new int [length];
    for (int i = 0; i < length; i++)
    {
        arr[i] = new Random().Next(0, 2);
    }
    return arr;
}

void PrintArray(int[] arr)
{
    int length = arr.Length;
    for (int i = 0; i < length; i++)
    {
        Console.Write($"{arr[i]}");
    }
}
PrintArray(ArrayCreation(8));
