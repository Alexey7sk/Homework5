// Задача 38: Задайте массив вещественных чисел. 
// Найдите разницу между максимальным и минимальным элементов массива.
// [3.22, 4.2, 1.15, 77.15, 65.2] => 77.15 - 1.15 = 76

int size = ReadInt("Введите количество элементов в массиве: ");
int min = ReadInt("Введите минимальное число массива: ");
int max = ReadInt("Введите максимальное число массива: ");
int [] numbers = new int[size];

FillArrayRandomNumbers(numbers);
PrintArray(numbers);

int maxFillArray = numbers[0];
int minFillArray = numbers[0];
for (int i = 0; i < numbers.Length; i++)
{
    if (numbers[i] > maxFillArray)
    {
        maxFillArray = numbers[i];
    }
    if (numbers[i] < minFillArray)
    {
        minFillArray = numbers[i];
    }
}
Console.WriteLine($"Разница между максимальным и минимальным числом = {maxFillArray - minFillArray}");

void FillArrayRandomNumbers(int [] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(min, max);
    }
}

void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
    Console.WriteLine();
}

int ReadInt(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}