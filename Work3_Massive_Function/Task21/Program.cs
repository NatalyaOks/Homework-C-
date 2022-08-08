/*
Задача 21

Напишите программу, которая принимает на вход координаты двух точек и находит расстояние 
между ними в 3D пространстве.

A (3,6,8); B (2,1,-7), -> 15.84

A (7,-5, 0); B (1,-1,9) -> 11.53

Вариант 1.
int[] pointA = new int[3];
int[] pointB = new int[3];


Console.WriteLine("Enter x1 coordinate:");
pointA[0] = int.Parse(Console.ReadLine());

Console.WriteLine("Enter y1 coordinate:");
pointA[1] = int.Parse(Console.ReadLine());

Console.WriteLine("Enter z1 coordinate:");
pointA[2] = int.Parse(Console.ReadLine());

Console.WriteLine("Enter x2 coordinate:");
pointB[0] = int.Parse(Console.ReadLine());

Console.WriteLine("Enter y2 coordinate:");
pointB[1] = int.Parse(Console.ReadLine());

Console.WriteLine("Enter z2 coordinate:");
pointB[2] = int.Parse(Console.ReadLine());

int a = pointA[0] - pointB[0];
int b = pointA[1] - pointB[1];
int c = pointA[2] - pointB[2];

double result = Math.Sqrt(a * a + b * b + c * c);

Console.WriteLine(Math.Round(result, 2));

Вариант 2.
double getDistance(int[] pointA, int[] pointB)
{
int a = pointA[0] - pointB[0];
int b = pointA[1] - pointB[1];
int c = pointA[2] - pointB[2];

double result = Math.Sqrt(a * a + b * b + c * c);
return result;
}


int[] pointA = new int[3];
int[] pointB = new int[3];


Console.WriteLine("Enter x1 coordinate:");
pointA[0] = int.Parse(Console.ReadLine());

Console.WriteLine("Enter y1 coordinate:");
pointA[1] = int.Parse(Console.ReadLine());

Console.WriteLine("Enter z1 coordinate:");
pointA[2] = int.Parse(Console.ReadLine());

Console.WriteLine("Enter x2 coordinate:");
pointB[0] = int.Parse(Console.ReadLine());

Console.WriteLine("Enter y2 coordinate:");
pointB[1] = int.Parse(Console.ReadLine());

Console.WriteLine("Enter z2 coordinate:");
pointB[2] = int.Parse(Console.ReadLine());

double result = getDistance(pointA, pointB);

Console.WriteLine(Math.Round(result, 2));
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
