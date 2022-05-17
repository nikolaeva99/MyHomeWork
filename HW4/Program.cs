// Задайте массив заполненный случайными положительными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

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

void ShowPositiveNum (int[] array)
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
ShowPositiveNum(newArray);
