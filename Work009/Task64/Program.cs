/*Задача 64: Задайте значения M и N. Напишите программу, которая выведет все натуральные 
числа в промежутке от M до N.

M = 1; N = 5. -> ""1, 2, 3, 4, 5""

M = 4; N = 8. -> ""4, 6, 7, 8""*/


void NaturalNum(int x, int y)
{
if (x == y+1) 
{
    return;
}

Console.Write(x + "\t");
x++;
NaturalNum(x,y);
}

Console.Write("Введите число М: ");
int numM = int.Parse (Console.ReadLine());

Console.Write("Введите число N: ");
int numN = int.Parse (Console.ReadLine());

NaturalNum(numM, numN);
