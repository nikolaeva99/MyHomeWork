/*
// Задача 1. Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
// 456 -> 5
// 782 -> 8
// 918 -> 1

void MidNum (int a)
{
    if (a > 99 | a < 999)
    {
        int b = (a / 10) % 10;
        Console.WriteLine("Middle number is " + b);
    }
    else 
    {
        Console.WriteLine("Input correct number");
    }
}
Console.Write("Input three-digit integer number: ");
int num = Convert.ToInt32(Console.ReadLine());
MidNum(num);
*/

// Задача 2. Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

void MiddNumShow(int a)
{
    if (a / 1000 > 1)
    {
        int result = a % 10;
        Console.WriteLine ("Third number is -> " + result);
    }
    else 
    {
        if (a / 1000 > 0.1)
            Console.WriteLine ("Third number is abcent!");
        else
            while (a / 1000 < 1)
            {
                int reduce = a / 10;
                a = reduce; 
            }
        int anotherResult = a % 10;
        Console.WriteLine ("Third number is мяу-> " + anotherResult);
    }
}
Console.Write("Input integer number: ");
int num = Convert.ToInt32(Console.ReadLine());
MiddNumShow(num);



/*
// Задача 3. Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
// 6 -> да
// 7 -> да
// 1 -> нет

void WeekDay(int a)
{
    if (a > 7 | a < 1)
    {
        Console.WriteLine ("Input correct number of the weekday");
    }
    else
    {
        if (a == 1) 
        Console.WriteLine ("It is not a weekend");
        if (a == 2) 
        Console.WriteLine ("It is not a weekend");
        if (a == 3) 
        Console.WriteLine ("It is not a weekend");
        if (a == 4) 
        Console.WriteLine ("It is not a weekend");
        if (a == 5) 
        Console.WriteLine ("It is not a weekend");
        if (a == 6) 
        Console.WriteLine ("It is a weekend!");
        if (a == 7) 
        Console.WriteLine ("It is a weekend!");
    }
}

Console.Write("Input integer number: ");
int num = Convert.ToInt32(Console.ReadLine());
WeekDay(num);
*/