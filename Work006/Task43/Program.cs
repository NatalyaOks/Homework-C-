/*Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных 
уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.

b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; 5,5)*/

Console.Write("Введите координаты первой прямой b1 и k1 через пробел: ");
double [] lineOne = Array.ConvertAll(Console.ReadLine().Split(), double.Parse);

Console.Write("Введите координаты второй прямой b2 и k2 через пробел: ");
double [] lineTwo = Array.ConvertAll(Console.ReadLine().Split(), double.Parse);

double y, x;

x = (lineOne[0]-lineTwo[0])/(lineTwo[1] - lineOne[1]);
y = lineOne[1] * x + lineOne[0];

x = Math.Round(x, 3);
y = Math.Round(y, 3);

Console.WriteLine($"Пересечение прямых в точке с координатами: ({x};{y})");






