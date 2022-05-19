/*
// Задача1. Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

double IncreaseNumber (double a, double b)
{
    double result = Math.Pow(a, b);
    return result;
}

Console.Write("Input number A: ");
double numA = Convert.ToDouble(Console.ReadLine());
Console.Write("Input number B: ");
double numB = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Result is " + IncreaseNumber(numA, numB));
*/

/*
// Задача 2. Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

int SumNum (int a)
{
   int result = 0;
   while (a >= 1)
   {
       int b = a % 10;
       result = result + b;
       a = a/10;
   }
   return result;

}

Console.Write("Input number: "); //376
int number = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Sum of number is " + SumNum(number));
*/

/*
// Задача 3. Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]


int[] CreateArray(int size)
{
    int[] array = new int [size];
    for (int i = 0; i < size; i++)
    {
        array[i] = new Random().Next(-100, 100);
    }
    return array;
}

void ShowArray (int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
    Console.WriteLine();
}

int[] myArray = CreateArray(8);
ShowArray(myArray);
*/