/* Задача 41: Пользователь вводит с клавиатуры M чисел. 
Посчитайте, сколько чисел больше 0 ввёл пользователь.
0, 7, 8, -2, -2 -> 2
1, -7, 567, 89, 223-> 3 */



// void PrintArray (int[] array)
// {
//     Console.Write($"[");
//     for (int i = 0; i < array.Length; i++)
//     {
//         if (i < array.Length -1) Console.Write($"{array[i]}, ");
//         else Console.Write($"{array[i]}");
//     }
//         Console.Write($"]");    
// }


// int[] ReadNumber(int size)
// {
//     int[] array2 = new int[size];
//     int i = 0;
//     while (i < size)
//         {
//         Console.WriteLine($"Enter your number: ");
//         array2[i] = Convert.ToInt32(Console.ReadLine());
//         i++;
//         }
//     return array2;
// }

// int PositiveNumber (int[] array)
// {
//     int counter = 0;
//     for (int i = 0; i < array.Length; i++)
//     {
//         if (array[i] > 0) counter++;
//     }
//     return counter;
// }

// Console.WriteLine($"Enter quantity of numbers that you are going to enter: ");
// int length = Convert.ToInt32(Console.ReadLine());
// int[] array1 = ReadNumber(length);
// string numbers = Console.ReadLine();
// Console.WriteLine($"Numbers that have been converted into array: ");
// PrintArray(array1);
// Console.WriteLine($"Quantity of numbers bigger than zero are: {PositiveNumber(array1)}");







// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, 
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и 
// k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)



Console.WriteLine("Enter b1 number: ");
double x1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter k1 number: ");
double y1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter b2 number: ");
double x2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter k2 number: ");
double y2 = Convert.ToInt32(Console.ReadLine());

double FindXPoint(double num1, double num2, double num3, double num4)
{
    double x = (-num3 + num1) / (-num2 + num4);
    return x;
}
double xresult = FindXPoint(x1, y1, x2, y2);
double FindYPoint(double num1, double num2, double num3, double num4, double result)
{
    double y = num4 * result + num3;
    return y;
}

Console.WriteLine($"b1 = {x1}, k1 = {y1}, b2 = {x2}, k2 = {y2} -> ({FindXPoint(x1, y1, x2, y2)}; {FindYPoint(x1, y1, x2, y2, xresult)}");

