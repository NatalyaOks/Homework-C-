﻿/*Задача 30: Напишите программу, которая выводит массив из N элементов, заполненный 
нулями и единицами в случайном порядке.
[1,0,1,1,0,1,0,0]*/

int[] FillArray(int n)
{
    int[] Array = new int[n];
    Random rnd = new Random();

    for (int i = 0; i < Array.Length; i++)
    {
        Array[i] = rnd.Next(0, 2);
    }

    return Array;
}

Console.WriteLine("Введите размерность массива : ");
int size = int.Parse(Console.ReadLine());

int[] Arr = FillArray(size);

for (int i = 0; i < Arr.Length; i++)
{
    Console.Write(Arr[i] + " ");
}