/*Урок 2. Массивы и функции в программировании
Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе 
показывает вторую цифру этого числа.
456 -> 5
782 -> 8
918 -> 1 */  

int SecondDigit (int arg)
{   int num2 = arg%100;
num2 = num2/10;         
return num2;
  };
Console.WriteLine("Задача 10.");
Console.Write("Введите трехзначное число: ");
int numN = int.Parse(Console.ReadLine());

int num = SecondDigit(numN);
Console.WriteLine("Вторая цифра заданного числа:" + num);

/* Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что 
третьей цифры нет.
645 -> 5
78 -> третьей цифры нет
32679 -> 6*/

Console.WriteLine(" ");
Console.WriteLine("Задача 13.");
Console.Write("Введите число: ");
int a = int.Parse(Console.ReadLine());
if (a < 100)
{
Console.WriteLine("В заданном числе нет третьей цифры.");  
}
else
{
  while (a > 999)
  {
  a = a / 10;
  }
  a = a % 10;
  Console.WriteLine("Третья цифра заданного числа: " + a);
}
/*Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и 
проверяет, является ли этот день выходным.
6 -> да
7 -> да
1 -> нет*/

Console.WriteLine(" ");
Console.WriteLine("Задача 15.");
Console.Write("Введите номер дня недели: ");
int numDay = int.Parse(Console.ReadLine());
if ((numDay >= 1) && (numDay <= 5))
{
  Console.WriteLine("Этот день не является выходным");
}
else if (numDay >= 6 && numDay <= 7)
{
  Console.WriteLine("Этот день является выходным");
}
else 
{
  Console.WriteLine("Введенное число не является номером дня недели.");
}


/*Дополнительное задание: Напишите программу, которая принимает на вход число N и выводит все 
простые числа в промежутке от 0 до N (включительно). После, попробуйте поэксперментировать с 
величиной значения N и понаблюдать за тем, как оно влияет на время выполнения программы.*/

Console.WriteLine(" ");
Console.WriteLine("Дополнительное задание.");
Console.Write("Введите конец диапазона от 2 до : ");
  int end=int.Parse(Console.ReadLine());
  for (int i=2; i<=end; i++) 
  {
   bool b=true;
   for(int j=2; j<i & j<11; j++)
   {
    if(i%j==0 & i%1==0) 
    {
     b=false;
    }
   }
   if(b) 
   {
    Console.Write("{0} ", i);
   }
  }
  //Console.ReadKey();
  //return 0;
