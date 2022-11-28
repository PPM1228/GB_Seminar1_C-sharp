/*Задача 25: Напишите цикл, который принимает на вход два числа (A и B)
и возводит число A в натуральную степень B.
3, 5 -> 243 (3⁵)
2, 4 -> 16*/

/*

void FindPower (int a)
{
    int power_result = 1;
    Console.WriteLine("Enter a number power: ");
    int num_b = Convert.ToInt32(Console.ReadLine());
    int power = num_b;

    for(int i = 1; i < num_b; i++)
    {
        power_result = a * (power);
    }
    Console.WriteLine($"Raising the number {a} to {power} power is {power_result}");
}

Console.WriteLine("Enter your number: ");
int num_a = Convert.ToInt32(Console.ReadLine());


FindPower (num_a);

*/



/*Задача 27: Напишите программу, которая принимает на вход число и 
выдаёт сумму цифр в числе.
452 -> 11
82 -> 10
9012 -> 12 */



int FindSum (int a)
{
    int sum = 0;
    int lastDigit = 0;
    while (a > 0)
    {
        lastDigit = a % 10;
        a = a / 10;
        sum = lastDigit + sum;
    }
    return sum;
}
Console.WriteLine("Enter your number: ");
int user_num = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"The sum of all digits in the number {user_num} is {FindSum (user_num)}.");




/*Задача 29: Напишите программу, которая задаёт массив из 8 элементов и
выводит их на экран.
1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
6, 1, 33 -> [6, 1, 33] */

/*


int [] CreateNewArray (int size)
{
    int [] array = new int [size];
    for (int i = 0; i < size; i++)
    {
        array [i] = new Random().Next(0, 99);
    }
    return array;
}

void ShowArray (int [] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]}  ");
    }
}

Console.Write("Enter number of your elements: ");
int number_of_elements = new Random().Next(8, 9);

int [] array1 = CreateNewArray (number_of_elements);
Console.WriteLine($"Your array numbers are: {array1}");
ShowArray(array1);


*/