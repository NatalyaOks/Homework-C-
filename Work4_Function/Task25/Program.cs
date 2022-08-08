/*Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A 
в натуральную степень B.
3, 5 -> 243 (3⁵)
2, 4 -> 16
*/
int GetExponent(int a, int b)
{
    int exponent = 1;
    int i = 1;
    while (i <= b)
    {
        exponent = exponent * a;
        i++;
    }
    return exponent;
}

Console.WriteLine("Введите число А: ");
int numberA = int.Parse(Console.ReadLine());

Console.WriteLine("Введите число B: ");
int numberB = int.Parse(Console.ReadLine());

Console.WriteLine("Число А в степени В равно: " + GetExponent(numberA, numberB));