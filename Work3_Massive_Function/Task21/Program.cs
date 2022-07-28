/*
Задача 21

Напишите программу, которая принимает на вход координаты двух точек и находит расстояние 
между ними в 3D пространстве.

A (3,6,8); B (2,1,-7), -> 15.84

A (7,-5, 0); B (1,-1,9) -> 11.53
*/

double Distance (int a1, int b1, int c1, int a2, int b2, int c2)
{
    double distance;
    return distance = Math.Round(Math.Sqrt(Math.Pow(a1-a2,2)+Math.Pow(b1-b2,2)+Math.Pow(c1-c2,2)),2);

}

Console.WriteLine("Введите координаты точки А: ");
Console.Write("А(x): ");
int aX = int.Parse(Console.ReadLine());
Console.Write("А(y): ");
int aY = int.Parse(Console.ReadLine());
Console.Write("А(z): ");
int aZ = int.Parse(Console.ReadLine());
Console.WriteLine("Введите координаты точки В: ");
Console.Write("B(x): ");
int bX = int.Parse(Console.ReadLine());
Console.Write("B(y): "); 
int bY = int.Parse(Console.ReadLine());
Console.Write("B(z): ");
int bZ = int.Parse(Console.ReadLine());

Console.WriteLine("Расстояние между точками " + Distance(aX,aY,aZ,bX,bY,bZ));
