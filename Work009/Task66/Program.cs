/*Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных 
элементов в промежутке от M до N.

M = 1; N = 15 -> 120
M = 4; N = 8. -> 30
*/

double SumNaturalNum(int x, int y)
{
    if (x == y)
    {
        return x;
    }
    return y + SumNaturalNum(x, --y);
}

Console.Write("Введите число М: ");
int numM = int.Parse(Console.ReadLine());

Console.Write("Введите число N: ");
int numN = int.Parse(Console.ReadLine());

Console.Write(SumNaturalNum(numM, numN));
