int[,] CreateNewMatrix (int m, int n)
{
    int[,] matrix = new int[m,n];
    for (int i = 0; i < m; i++)
    {
        for(int j = 0; j < n; j++)
        {
            matrix[i,j] = 5 - new Random().Next(-10, 10);
        }
    }
    return matrix;
}

void ShowMatrix(int[,] matrix)
{
     for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for(int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write(matrix[i,j] + " ");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}

/*
// Задача 1. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

double[,] CraeteMatrix(int m, int n)
{
    double[,] matrix = new double[m,n];
    for (int i = 0; i < m; i++)
    {
        for(int j = 0; j < n; j++)
        {
            matrix[i,j] = 5 - new Random().Next(11) + new Random().NextDouble();
        }
    }
    return matrix;
}


void ShowMatrix (double[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for(int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write(matrix[i,j] + " ");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}

Console.Write("Input number of strings: ");
int numOfStrings = Convert.ToInt32(Console.ReadLine());
Console.Write("Input number of columns: ");
int numOfColunmns = Convert.ToInt32(Console.ReadLine());
double[,] myMatrix = CraeteMatrix(numOfStrings, numOfColunmns);
ShowMatrix(myMatrix);
*/


// Задача 2. Напишите программу, которая на вход принимает позиции элемента в 
// двумерном массиве, и возвращает значение этого элемента или же указание, 
// что такого элемента нет.



int numOfStrings = 8;
int numOfColunmns = 10;
int[,] myNewMatrix = CreateNewMatrix(numOfStrings, numOfColunmns);
Console.Write("Inpup num of string: ");
int str = Convert.ToInt32(Console.ReadLine());
Console.Write("Input num of column: ");
int clmn = Convert.ToInt32(Console.ReadLine());

if (str < 0 | clmn < 0) Console.WriteLine("Input Correct number! ");
if (str > numOfStrings | clmn > numOfColunmns)
{
    Console.WriteLine("Input correct number! ");
}
else
{
    Console.WriteLine(myNewMatrix[str, clmn]);
}

/*
// Задача 3. Задайте двумерный массив из целых чисел. Найдите среднее 
// арифметическое элементов в каждом столбце.


double SumOfColumnsEl (int[,] matrix)
{
    int sum = 0;
    int count = 0;
    double result = 0;
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for(int j = 0; j < matrix.GetLength(1); j++)
        {
            sum += matrix[i,j];
            count ++;
        }
        result = sum / count;
        
    }
    return result;
    Console.Write(result + "; ");
}


Console.Write("Input number of strings: ");
int numOfStrings = Convert.ToInt32(Console.ReadLine());
Console.Write("Input number of columns: ");
int numOfColunmns = Convert.ToInt32(Console.ReadLine());
int[,] myNewMatrix = CreateNewMatrix(numOfStrings, numOfColunmns);
ShowMatrix(myNewMatrix);
Console.WriteLine("Average of column`s elements is: " + SumOfColumnsEl(myNewMatrix));
*/