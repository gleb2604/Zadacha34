/* Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
[345, 897, 568, 234] -> 2 */

int[] GetRandomArray(int size, int leftRange, int rightRange)
{
    int[] array = new int[size];

    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(leftRange, rightRange);
    }
    return array;
}

const int SIZE = 10;
const int LEFT = 100;
const int RIGHT = 1000;

int[] massive = GetRandomArray(SIZE, LEFT, RIGHT);
Console.WriteLine(string.Join(", ", massive));


// Количество четных числе в массиве:
int Addition(int[] array)
{
    int num = 0;
    for (int i = 0; i < massive.Length; i++)
    {
        int temp = massive[i] % 2;
        if (temp == 0) num += 1;
    }
    return num;
}

Console.WriteLine($"Количество чётных чисел в массиве: {Addition(array: massive)}");