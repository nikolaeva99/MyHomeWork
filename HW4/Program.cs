// Задача1. Задайте массив заполненный случайными положительными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

/*
int[] PrintArray (int size)
{
    int[] array = new int[size];
    for (int i = 0; i < size; i++)
    {
        array[i] = new Random().Next(100, 999);
    }
    return array;
}

void ShowArray (int[] array)
{
    for (int i = 0; i < array.Length; i++)
        Console.Write(array [i] + " ");
    
    Console.WriteLine();
}

void ShowEvenNum (int[] array)
{
    int current = 0;
    for (int i = 0; i < array.Length; i++)
    {
        
        if (array[i] % 2 == 0) current = current +1;
    }
    Console.WriteLine("Amount of positive numbers is " + current);
}

int[] newArray = PrintArray(4);
ShowArray(newArray);
ShowEvenNum(newArray);
*/


// Задача 2. Задайте одномерный массив, заполненный случайными числами. 
// Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0
/*

int[] CreateArray (int size, int min, int max)
{
    int[] array = new int [size];
    for (int i = 0; i < size; i++)
    {
        array[i] = new Random().Next(min, max+1);
    }
    return array;
}

void ShowArray (int[] array)
{
    for (int i = 0; i < array.Length; i++)
    Console.Write(array[i] + " ");

    Console.WriteLine();
}

void SumEvenNumber (int[] array)
{
    int sumEven = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (i % 2 == 0) sumEven = sumEven + array[i];
  
    }
    Console.WriteLine(sumEven);
}

int[] myArray = CreateArray(4, 0, 100);
ShowArray(myArray);
SumEvenNumber(myArray);
*/

/*
// Задача 3. Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76

double[] newArray (int size)
{
    double[] array = new double [size];
    for (int i = 0; i < size; i++)
    {
        array [i] = new Random().Next (-1000, 1000);
    }
    return array;
}

void ShowArray (double[] array)
{
    for (int i = 0; i < array.Length; i++)
        Console.Write(array[i] + " ");

        Console.WriteLine();
}

double FindMax (double[] array)
{
    double max = array[1];
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > max)
        {
            max = array[i];
        }
    }
    return max;
}

double FindMin (double[] array)
{
    double min = array[1];
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] < min)
        {
            min = array[i];
        }
    }
    return min;
}

double[] myArray = newArray(8);
ShowArray(myArray);
Console.WriteLine("Max number is " + FindMax(myArray));
Console.WriteLine ("Min number is " + FindMin(myArray));
double residual = FindMax(myArray) - FindMin(myArray);
Console.WriteLine("Residual between max and min is: " + residual);
*/