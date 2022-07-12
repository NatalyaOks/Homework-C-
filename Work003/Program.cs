// Задача 6: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).
// 4 -> да
// -3 -> нет
// 7 -> нет
Console.WriteLine("Введите число:");
int numA = int.Parse (Console.ReadLine());
if (numA%2 == 0) Console.WriteLine ("Число "+numA+" четное");
else Console.WriteLine("Число " +numA+" нечетное");