/*Задача 34: Задайте массив заполненный случайными положительными 
трёхзначными числами. Напишите программу, которая покажет количество 
чётных чисел в массиве.
[345, 897, 568, 234] -> 2 */


/*
int [] CreateRandomArray (int size, int minValue, int maxValue)
{
    int [] newArray = new int [size];
    for (int i = 0; i < size; i++)
    {
        newArray[i] = new Random().Next(100, 1000);
    }
    return newArray;
}

void ShowArray (int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
    Console.WriteLine();
}

int evenNumber (int[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] % 2 == 0) count++;
    }
    return count;
}
Console.Write($"Our array is ");
int[] array1 = CreateRandomArray(4, 100, 1000);
ShowArray(array1);
Console.WriteLine($"{evenNumber} are quantity of even numbers in the array");


*/

/* Задача 36: Задайте одномерный массив, заполненный случайными числами. 
Найдите сумму элементов, стоящих на нечётных позициях.
[3, 7, 23, 12] -> 19
[-4, -6, 89, 6] -> 0 */

/*

int [] CreateRandomArray (int size, int minValue, int maxValue)
{
    int[] newArray = new int [size];
    for (int i = 0; i < size; i++)
    {
        newArray[i] = new Random().Next(minValue, maxValue);
    }
    return newArray;
}

void ShowArray (int [] array)
{
    for (int i = 0; i < array.Length; i++);
    {
        Console.Write(array[i] + " ");
    }
    Console.WriteLine();
}

int SumOfOddNumber (int[] array)
{
    int sum = 0;
    for (int i = 0; i < size; i++)
    {
        if (i % 2 != 0) sum = sum + array[i];
    }
    return sum;
}

Console.Write($"Our array is ");
int[] array1 = CreateRandomArray(4, 0, 100);
ShowArray(array1);
Console.WriteLine($"{SumOfOddNumber} is the sum of odd numbers in the array");


*/



/* Задача 38: Задайте массив вещественных чисел. Найдите разницу между 
максимальным и минимальным элементов массива.
[3 7 22 2 78] -> 76 */



int[] CreateRandomArray (int size, int minValue, int maxValue)
{
    int[] newArray = new int[size];
    for (int i = 0; i < size; i++)
    {
        newArray[i] = new Random().Next(minValue, maxValue);
    }
    return newArray;
}

void ShowArray (int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
    Console.WriteLine();
}

int FindDifference (int[] array)
{
    int min = 0;
    int max = 0;
    int diff = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > max) 
        {
            max = array[i];
            min = max;
        }
        else if (array[i] < min) min = array [i];
    }
    diff = max - min;
    return diff;
}

Console.Write($"Our array is ");
int[] array1 = CreateRandomArray(5, 0, 100); //  5 - длина массива, от 0 и до 99.
ShowArray(array1);
Console.WriteLine($"{FindDifference} is the diffefrence between max and min numbers in the array");



/*
Для вещественных (нецелых) чисел и для себя :)

{
    double[] array = new double[size];
    Random rnd = new Random(); 
    for (int i = 0; i < array.Length; i++)
        {
            array[i] = rnd.NextDouble() * (max - min) + min;
            array[i] = Math.Round(array[i], 1);
        }
    return array;
}

*/