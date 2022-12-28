/*Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке
от N до 1. Выполнить с помощью рекурсии.
N = 5 -> "5, 4, 3, 2, 1"
N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1" */


// void ShowNumbers (int n)
// {
//     Console.WriteLine(n + " ");
//     if (n > 1) ShowNumbers(n - 1);
// }
// Console.Write("Enter your number: ");
// int userNum = Convert.ToInt32(Console.ReadLine());

// ShowNumbers (userNum);



/*Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в 
промежутке от M до N.
M = 1; N = 15 -> 120
M = 4; N = 8. -> 30 */



// int FindSum(int n, int m)
// {
//     if(n == m) return m;
//     return FindSum(n + 1, m)+ n;    
// }

// Console.Write("Enter number M: ");
// int numM = Convert.ToInt32(Console.ReadLine());
// Console.Write("Enter number N: ");
// int numN = Convert.ToInt32(Console.ReadLine());

//  int result = FindSum(numM, numN);
//  Console.WriteLine (result);




/*Задача: Написать рекурсивную функцию перевода из десятичной системы исчисления в двоичную*/


// int BinarySystem(int n, int temp, string m)
// {
//     if (n == 0) return 0;
//     {
//         temp = new string (m);
//         m = (n % 2) + m;
//         return BinarySystem (n / 2);
//     }
// }

// Console.Write("Enter you decimal number : ");
// int num1 = Convert.ToInt32(Console.ReadLine());

//  int result = BinarySystem(num1);
//  Console.WriteLine (result);

