// // Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
// // m = 3, n = 4.
// // 0,5 7 -2 -0,2
// // 1 -3,3 8 -9,9
// // 8 7,8 -7,1 9


// double[,] Create2dArray (int row, int column, int minVal, int maxVal)
// {
//     double[,] created2dArray = new double [row, column];
//     for (int i = 0; i < row; i++)
//         for (int j = 0; j < column; j++)
//             created2dArray [i, j] = Math.Round (new Random().Next(minVal, maxVal + 1) + new Random().NextDouble(), 3);
//     return created2dArray;
// }

// void Show2dArray (double[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             Console.Write(array[i, j] + " ");
//         }
//         Console.WriteLine();
//         }
//     Console.WriteLine();
// }

// Console.Write("Enter number of rows: ");
// int rows = Convert.ToInt32(Console.ReadLine());

// Console.Write("Enter number of columns: ");
// int columns = Convert.ToInt32(Console.ReadLine());

// Console.Write("Enter min possible value: ");
// int min = Convert.ToInt32(Console.ReadLine());

// Console.Write("Enter max possible value: ");
// int max = Convert.ToInt32(Console.ReadLine());

// double [,] newArray = Create2dArray(rows, columns, min, max);
// Show2dArray(newArray);




// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
// и возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет



int[,] Create2dArray (int row, int column, int minVal, int maxVal)
{
    int[,] created2dArray = new int [row, column];
    for (int i = 0; i < row; i++)
    {
        for (int j = 0; j < column; j++)
        {
            created2dArray [i, j] = new Random().Next(minVal, maxVal + 1);
    
        }
    }
    return created2dArray;
}

void Show2dArray (int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + " ");
        }
        Console.WriteLine();
        }
    Console.WriteLine();
}

int FindNum (int number, int number2, int[,] array)
{
    int position = array[number, number2];
    return position;
}


int row = 0;
int column = 0;
int user_num = 0;
int user_num2 = 0;
while (row <= 0 || column <= 0 || user_num < 0 || user_num2 < 0)
{
    Console.WriteLine($"Enter number of rows: ");
    row = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine($"Enter number of columns: ");
    column = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine($"Enter row index: ");
    user_num = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine($"Enter column index: ");
    user_num2 = Convert.ToInt32(Console.ReadLine());
    if (row <= 0 || column <= 0 && user_num < 0 || user_num2 < 0)
    Console.WriteLine("Incorrect data have been entered");
}

Console.Write("Enter min possible value: ");
int min = Convert.ToInt32(Console.ReadLine());

Console.Write("Enter max possible value: ");
int max = Convert.ToInt32(Console.ReadLine());

int [,] newArray = Create2dArray(row, column, min, max);
Show2dArray(newArray);

Console.WriteLine(user_num <= row & user_num2 <= column ?
$"{FindNum(user_num, user_num2, newArray)} - Array element of the stated index" :
 "There is no such element in the array");





// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в 
// каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.



// int[,] Create2dArray (int row, int column, int minVal, int maxVal)
// {
//     int[,] created2dArray = new int [row, column];
//     for (int i = 0; i < row; i++)
//     {
//         for (int j = 0; j < column; j++)
//         {
//             created2dArray [i, j] = new Random().Next(minVal, maxVal + 1);
    
//         }
//     }
//     return created2dArray;
// }

// void Show2dArray (int[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             Console.Write(array[i, j] + " ");
//         }
//         Console.WriteLine();
//         }
//     Console.WriteLine();
// }

// int row = 0;
// int column = 0;

// while (row <= 0 || column <= 0)
// {
//     Console.WriteLine($"Enter number of rows: ");
//     row = Convert.ToInt32(Console.ReadLine());
//     Console.WriteLine($"Enter number of columns: ");
//     column = Convert.ToInt32(Console.ReadLine());
//     if (row <= 0 || column <= 0)
//     Console.WriteLine("Incorrect data have been entered");
// }

// double [] AverageSum (int[,]array)
// {
//     double[] newArray = new double [array.GetLength(1)];
//     for (int i = 0; i < newArray.Length; i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             double sum = 0;
//             for (int k = 0; k < array.GetLength(0); k++)
//             {
//                 sum = sum + array[k,i];
//                 newArray[i] =  Math.Round(sum / array.GetLength(0), 2);
//             }
//         }
//     }
//     return newArray;
// }

// void PrintArray(double[] array)
// {
//     Console.Write($"[");
//     for (int i = 0; i < array.Length; i++)
//     {
//         if (i < array.Length - 1) Console.Write($"{array[i]}| ");
//         else Console.Write($"{array[i]}");
//     }
//     Console.Write($"]");
// }

// int[,] new2dArray = Create2dArray(row, column, 0, 10);
// Show2dArray (new2dArray);
// double[] finalArray = AverageSum (new2dArray);
// PrintArray(finalArray);