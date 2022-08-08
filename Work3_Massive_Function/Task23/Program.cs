/*
Задача 23

Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

3 -> 1, 8, 27
5 -> 1, 8, 27, 64, 125
*/
Console.Write("Введите число: ");
int numN = int.Parse(Console.ReadLine());
for (int i=1; i<=numN; i++)
{
    int cube = i*i*i;
    Console.Write(cube+" ");
}