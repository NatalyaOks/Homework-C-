/*Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
Напишите программу, которая покажет количество чётных чисел в массиве.

[345, 897, 568, 234] -> 2
*/


void PrintFillArray(int[] arr)
{
    Console.Write("[");
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = new Random().Next(100, 1000);
        if (i < arr.Length - 1)
        {
            Console.Write(arr[i] + ", ");
        }
        else
        {
            Console.Write(arr[i]);
        }
    }
    Console.Write("]");
}

void CountEvenNumbersArray(int[] arr)
{
    int j = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] % 2 == 0)
        {
            j++;
        }
    }
    Console.WriteLine("Количество четных чисел в массиве: " + j);
}


Console.Write("Введите количество элементов массива: ");
int n = int.Parse(Console.ReadLine());
int[] array = new int[n];

PrintFillArray(array);
Console.WriteLine();
CountEvenNumbersArray(array);

