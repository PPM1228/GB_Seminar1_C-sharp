/* Задача 19
Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
14212 -> нет
12821 -> да
23432 -> да */

void Palindrome(int number)
{
    int current = number / 1000;

    if (current / 100 == 0)
    {
        if ((number / 10000) == (number % 10) && (current % 10) == (number % 100) / 10)
        {
            Console.WriteLine($"The number {number} is a polindrome");
        }
        else Console.WriteLine($"The number {number} is not a polindrome");
    }
    else Console.WriteLine($"The number {number} aint have 5 digits");
}
Console.WriteLine("To know whether a number is a polindrome or not, enter a five-digit number: ");
int number = Convert.ToInt32(Console.ReadLine());

Palindrome(number);



/* Задача 21
Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
A (3,6,8); B (2,1,-7), -> 15.84
A (7,-5, 0); B (1,-1,9) -> 11.53 */


/*

double LongLine(int x1, int x2, int y1, int y2, int z1, int z2)
{
    int x = x2 - x1;
    int y = y2 - y1;
    int z = z2 - z1;

    double lengthAB = Math.Sqrt((x*x + (y*y)) + (z*z));
    return lengthAB;
}

Console.WriteLine("Enter X coordinate of A: ");
int xA = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Enter Y coordinate of A: ");
int yA = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Enter X coordinate of B: ");
int xB = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Enter X coordinate of B: ");
int yB = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Enter Z coordinate of A: ");
int zA = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Enter Z coordinate of B: ");
int zB = Convert.ToInt32(Console.ReadLine());

double distance = LongLine(xA, yA, xB, yB, zA, zB);

Console.WriteLine($"The distance between A, B, and Z is {distance:f3}"); 

*/

/* Задача 23
Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
3 -> 1, 8, 27
5 -> 1, 8, 27, 64, 125 */


/*

void Cube(int number)
{
    int current = 1;
    while (current <= number)
    {
        int result = current * current * current;
        Console.Write($"{result}, ");
        current ++;
    }
    Console.Write("{\b\b}."); // "\b" Удаляет 1 символ.
}

Console.WriteLine("Enter your number: ");
int number = Convert.ToInt32(Console.ReadLine());

if (number >= 1)
{
    Console.Write($"{number} -> ");
    Cube(number);
}

else Console.WriteLine("Incorrect number!");

*/