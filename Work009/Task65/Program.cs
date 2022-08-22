/*Задача 65: Задайте значения M и N. Напишите функцию, которая выведет все натуральные числа в промежутке от M до N.
M = 1; N = 5. -> "1, 2, 3, 4, 5"
M = 4; N = 8. -> "4, 5, 6, 7, 8"
!!Вывести числа наоборот!!*/

/*void NaturalNum(int start, int end)
{
    if (start < end)
    {
        return;
    }
    Console.Write(start + "\t");
    start--;
    NaturalNum(start, end);
}

Console.WriteLine("Введите число: ");
int n = int.Parse(Console.ReadLine());
Console.WriteLine("Введите число: ");
int m = int.Parse(Console.ReadLine());
NaturalNum(m, n);*/

Console.WriteLine("Введите число N ");
int n = int.Parse(Console.ReadLine());
//Console.WriteLine(--n);
Console.Write(Naturalback(n, " "));

string Naturalback(int start, string res)
{
    if (start == 0)
    {
        return res;
    }
    //Console.Write(start + "\t"+ Naturalback(start--));
    return ($"{start}  \t {Naturalback(--start, res)} ");
 }
