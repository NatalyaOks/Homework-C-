/* Задача 24: Напишите программу, которая принимает на вход число (А) и выдаёт сумму чисел 
от 1 до А.
7 -> 28
4 -> 10
8 -> 36
Задача 28. Напишите программу, которая принимает на вход число N и выдаёт 
произведение чисел от 1 до N.
4 -> 24 
5 -> 120
*/


Console.Write("Введите число А: ");
int a = int.Parse(Console.ReadLine());
int sum = 0;
int composit = 1;

for (int i = 1; i <= a; i++)
    {
        sum = sum + i;
        composit = composit * i;
    }
Console.WriteLine("Сумма чисел от 1 до А равна " + sum);
Console.WriteLine("Произведение чисел от 1 до А равн0 " + composit);