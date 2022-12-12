// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы
// каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2



// int[,] Create2dArray(int row, int column, int min, int max)
// {
//     int[,] newArray = new int[row, column];
//     for (int i = 0; i < row; i++)
//     {
//         for (int j = 0; j < column; j++)
//         {
//             newArray[i, j] = new Random().Next(min, max + 1);
//         }
//     }
//     return newArray;
// }


// void Show2dArray(int[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             Console.Write(array[i, j] + " ");
//         }
//         Console.WriteLine();
//     }
//     Console.WriteLine();
// }

// void ArrayLinesOrdering(int[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             for (int k = 0; k < array.GetLength(1) - 1; k++)
//             {
//                 if (array[i, k] < array[i, k + 1])
//                 {
//                     int temp = array[i, k + 1];
//                     array[i, k + 1] = array[i, k];
//                     array[i, k] = temp;
//                 }
//             }
//         }
//     }
// }

// Console.WriteLine("Enter number of rows: ");
// int user_row = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine("Enter number of columns: ");
// int user_column = Convert.ToInt32(Console.ReadLine());


// Console.Write("Enter min possible value of the array: ");
// int user_min = Convert.ToInt32(Console.ReadLine());

// Console.Write("Enter max possible value of the array: ");
// int user_max = Convert.ToInt32(Console.ReadLine());

// int[,] createdArray = Create2dArray(user_row, user_column, user_min, user_max);
// Show2dArray(createdArray);

// Console.WriteLine($"The sorted array is: ");
// ArrayLinesOrdering(createdArray);
// Show2dArray(createdArray);





// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку
// с наименьшей суммой элементов.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка



// int[,] Create2dArray(int row, int column, int min, int max)
// {
//     int[,] newArray = new int[row, column];
//     for (int i = 0; i < row; i++)
//     {
//         for (int j = 0; j < column; j++)
//         {
//             newArray[i, j] = new Random().Next(min, max + 1);
//         }
//     }
//     return newArray;
// }

// void Show2dArray(int[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             Console.Write(array[i, j] + " ");
//         }
//         Console.WriteLine();
//     }
//     Console.WriteLine();
// }

// int RowSum(int[,] array, int i)
// {
//     int rowSum = array[i, 0];
//     for (int j = 1; j < array.GetLength(1); j++)
//     {
//         rowSum = rowSum + array[i, j];
//     }
//     return rowSum;
// }


// Console.WriteLine("Enter number of rows: ");
// int user_row = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine("Enter number of columns: ");
// int user_column = Convert.ToInt32(Console.ReadLine());

// Console.Write("Enter min possible value of the array: ");
// int user_min = Convert.ToInt32(Console.ReadLine());

// Console.Write("Enter max possible value of the array: ");
// int user_max = Convert.ToInt32(Console.ReadLine());


// int[,] newArray = Create2dArray(user_row, user_column, user_min, user_max);
// Show2dArray(newArray);

// int minRowSum = 0;
// int rowSum = RowSum(newArray, 0);
// for (int i = 1; i < newArray.GetLength(0); i++)
// {
//     int tempSumLine = RowSum(newArray, i);
//     if (rowSum > tempSumLine)
//     {
//         rowSum = tempSumLine;
//         minRowSum = i;
//     }
// }

// Console.WriteLine($"Row {minRowSum + 1} includes the smallest sum of elements equal to {rowSum}");




