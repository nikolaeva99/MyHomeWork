﻿/*
//Задача 1.  Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее. 
// a = 5; b = 7 -> max = 7
// a = 2 b = 10 -> max = 10
// a = -9 b = -3 -> max = -3
Console.Write("Input first number ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Input second number ");
int num2 = Convert.ToInt32(Console.ReadLine());
if (num1 > num2)
{
    Console.WriteLine("Max number is " + num1);
}
else 
{
    Console.WriteLine("Max number is " + num2);
}
*/

/*
// Задача 2. Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
// 2, 3, 7 -> 7
// 44 5 78 -> 78
// 22 3 9 -> 22
Console.Write("Input first number ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Input second number ");
int num2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Input third number ");
int num3 = Convert.ToInt32(Console.ReadLine());
int max = num1;
if (num1 > max) max = num1;
if (num2 > max) max = num2;
if (num3 > max) max = num3;
   
Console.WriteLine("Max number is " + max);
*/

/*
// Задача 3. Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным.
// 4 -> да
// -3 -> нет
// 7 -> нет
Console.Write("Input integer number ");
int num = Convert.ToInt32(Console.ReadLine());
if (num % 2 == 0) 
    Console.WriteLine(num + " четное число");
else
    Console.WriteLine(num + " нечетное число");
*/


//Задача 4. Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
// 5 -> 2, 4
// 8 -> 2, 4, 6, 8


Console.Write("Input integer number ");
int num = Convert.ToInt32(Console.ReadLine());
int current = 1;


if (num > 0)
{
    Console.Write(current + " ");
}
else 
    current++;
while (current <= num);
