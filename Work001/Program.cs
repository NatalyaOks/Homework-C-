﻿// Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт максимальное из этих чисел.
//a = 5; b = 7 -> max = 7 
//a = 2 b = 10 -> max = 10 
//a = -9 b = -3 -> max = -3
Console.WriteLine("Введите число а:");
int numA = int.Parse(Console.ReadLine());
Console.WriteLine("Введите число b:");
int numB = int.Parse (Console.ReadLine());
int max=0;
if (numA > numB) 
{max = numA;
Console.WriteLine("Максимальное число равно "+max);}
else if (numB>numA)
{max=numB;
Console.WriteLine("Максимальное число равно "+max);}
else Console.WriteLine("Числа равны");