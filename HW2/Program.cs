/*
// Задача 1. В которой 
// Метод то строчки 1-21


int ShowNumber(int n)
{
    int firstNum = n/10;
    int secondNum = n % 10;

// Чтобы сделать наглядо сделаем промежуточный вывод;

    Console.Write(n + " -> ");

    if (firstNum > secondNum)
    {
        return firstNum;
    }
    else
    {
        return secondNum;
    }
}


int num = new Random().Next(10,99); // сгенерировали нам
int a = ShowNumber(num); // после чего отправили нам в качестве аргкмента в метод
Console.WriteLine (a);


// Задача 1. Второе решение

void ShowNumber()
{
    int num = new Random().Next(10, 99);

    Console.Write(num + " -> ");

    if (num/10 > num %10)
    {
        Console.Write(num/10);
    }
    else 
        Console.WriteLine(num % 10);
}

ShowNumber();
*/

/*

//Задача 2. выводит 3х значное число и удаляет 2-е по счету.

void DelMidNum ()
{
    int num = new Random().Next(100, 999);
    int num1 = num/100;
    int num3 = num % 10;

    Console.Write (num + "->");
    Console.Write (num1*10 + num3);
}
DelMidNum();
*/
/*
// Задача 3. Метод Принимает на вход 2 числа и проверяет делится ли одно их них на другое. Если нет - вывести остаток от деления

void DelCheck (int num1,
               int num2)
{
    int del1 = num1 % num2;
    
    if (del1 == 0)
    {
        Console.WriteLine(num1 + " делится нацело на " + num2);
    }
    else
    {
        Console.WriteLine(num1 + " не делится нацело на " + num2);
        Console.WriteLine ("Остаток равен "+ del1);
    }
}
 Console.Write("Input first integer number: ");
 int num1 = Convert.ToInt32(Console.ReadLine());
 Console.Write("Input second integer number: ");
 int num2 = Convert.ToInt32(Console.ReadLine());

DelCheck(num1, num2);
*/

/*
// Задача 4. Метод в котором проверить - принимает на вход число и кратоно ли оно и 7ке И 23

void MultipleCheck(int num1)
{
    int mult1 = num1 % 7;
    int mult2 = num1 % 23;

    if (mult1 == 0 | mult2 == 0)
    {
        Console.WriteLine (num1 + " is multipled of both" );
    }
    else
    {
        Console.WriteLine (num1 + " is NOT multipled of them");
    }
}

Console.Write("Input integer number: ");
int num1 = Convert.ToInt32(Console.ReadLine());
MultipleCheck(num1);
*/
/*
// Задача 5. принимает 2 числа и является ли одно число квадратом другого 

void SqdCheck (int a, int b)
{
    if (a == b*b)
    {
        Console.WriteLine("First number is quad of second number");
    }
    else
    {
        Console.WriteLine("First number is NOT quad of second number");
    }
}
Console.Write("Input first integer number: ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Input second integer number: ");
int num2 = Convert.ToInt32(Console.ReadLine());

SqdCheck(num1,num2);
*/







/*
// Задача 10. Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
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

// Задача 11. Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

void MiddNumShow(int a)
{
    a/
}
Console.Write("Input integer number: ");
int num = Convert.ToInt32(Console.ReadLine());
MiddNumShow();



/*
// Задача 12. Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
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