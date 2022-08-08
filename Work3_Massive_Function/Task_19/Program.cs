/*
Задача 19

Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно 
палиндромом.

14212 -> нет

12821 -> да

23432 -> да
*/
bool IsPalindrome (string s)
{
  for(int i=0; i < s.Length/2; i++)
    if (s[i] == s[s.Length-i-1]) 
    {
        return true;
    }  
    return false;
}

Console.WriteLine("Введите пятизначное число: ");
string number = Console.ReadLine();
if (int.Parse(number) > 9999 && int.Parse(number) < 100000)
{
    if (IsPalindrome(number) == true)
    {
        Console.WriteLine("Число " + number + " является палиндромом");
    }
    else
    Console.WriteLine("Число " + number + " не является палиндромом");
}
else Console.WriteLine("Введено не пятизначное число!");