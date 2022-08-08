/*
Напишите программу, которая принимает на вход число и выдаёт количество цифр в числе.
456 -> 3
78 -> 2
89126 -> 5

Вариант 1.
Console.Write("Введите число А: ");
string  a = Console.ReadLine();
Console.WriteLine(a.Length);
*/

Console.Write("Введите число А: ");
string  a = Console.ReadLine();
int b = int.Parse(a);
int i=0;
while (b != 0)
{
    b = b/10;
    i++; 
}
Console.WriteLine(i);