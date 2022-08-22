/*
Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два 
неотрицательных числа m и n.

m = 2, n = 3 -> A(m,n) = 29
*/

Console.Write("Введите неотрицательное число М: ");
int numM = int.Parse(Console.ReadLine());

Console.Write("Введите неотрицательное число N: ");
int numN = int.Parse(Console.ReadLine());

Console.Write(FuncAccerman(numM, numN));

int FuncAccerman(int m, int n)
{
    if (m == 0)
    {
        return n + 1;
    }
    else if (m > 0 & n == 0)
    {
        return FuncAccerman(m - 1, 1);
    }
    else if (m > 0 & n > 0)
    {
        return FuncAccerman(m - 1, FuncAccerman(m, n - 1));
    }
    return FuncAccerman(m,n);
}

