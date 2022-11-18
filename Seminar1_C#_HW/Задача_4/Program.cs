/*Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
2, 3, 7 -> 7
44 5 78 -> 78
22 3 9 -> 22 */

Console.WriteLine("To find out the biggest number out of three, enter the first number: ");
int number1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Enter the second number: ");
int number2 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Enter the third number: ");
int number3 = Convert.ToInt32(Console.ReadLine());

int the_biggest = 0;

if ((number1 > number2) && (number1 > number3))
{
    the_biggest = number1;
}
if ((number2 > number3) && (number2 > number1));
{
    the_biggest = number2;
}
if ((number3 > number1) && (number3 > number2));
{
    the_biggest = number3;
}
Console.WriteLine($"Number {the_biggest} is the biggest one out of these three numbers");