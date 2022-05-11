// Задача 1. Напишите программу, которая на вход принимает пятизначное число и проверяет, является ли оно палиндромом
// 14212 -> нет
// 12821 -> да
// 23432 -> да

/*
void Palindrome (int a)
{
    int lastNum = a % 10;
    int firstNum = a / 10000;
    int preLastNum = (a % 100) / 10;
    int secondNum = (a / 1000) % 10;

    if (a / 100000 >= 1 | a / 10000 < 0.1)
    Console.WriteLine("Input 5-digit number!");
    else 
        if (lastNum == firstNum && preLastNum ==secondNum)
        {
            Console.WriteLine ("The number is palindrome");
        }
        else 
        {
            Console.WriteLine ("The number is NOT palindrome");
        }
}

Console.Write ("Input 5-digit number: ");
int num = Convert.ToInt32(Console.ReadLine());
Palindrome (num);
*/

/*
// Задача 2. Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
// А (3, 6, 8); В (2, 1, -7) -> 15.84
// А (7, -5, 0); В (1, -1, 9) -> 11.53

void LengthFind (double a, double b, double c, double d, double e, double f)
{
    double result = Math.Sqrt((d - a) * (d - a) + (e - b) * (e - b) + (f - c) * (f - c));
    Console.Write("The lenght is -> " + result);
}

Console.Write ("Input Ax coordinate: ");
double dotAx = Convert.ToDouble(Console.ReadLine());
Console.Write ("Input Ay coordinate: ");
double dotAy = Convert.ToDouble(Console.ReadLine());
Console.Write ("Input Az coordinate: ");
double dotAz = Convert.ToDouble(Console.ReadLine());

Console.Write ("Input Bx coordinate: ");
double dotBx = Convert.ToDouble(Console.ReadLine());
Console.Write ("Input By coordinate: ");
double dotBy = Convert.ToDouble(Console.ReadLine());
Console.Write ("Input Bz coordinate: ");
double dotBz = Convert.ToDouble(Console.ReadLine());

LengthFind (dotAx, dotAy, dotAz, dotBx, dotBy, dotBz);
*/




/*
// Задача 3. Напишите программу, которая принимает на вход число N и выдает таблицу кубов чисел от 1 до N.

void TableCube (int N)
{
    int current = 1;
    Console.Write (N + " -> ");
    while (current <= N)
    {
        int result = current * current * current;
        Console.Write(result + " ");
        current++;
    }
}

Console.Write ("Input integer number: ");
int num = Convert.ToInt32(Console.ReadLine());
TableCube(num);
*/

