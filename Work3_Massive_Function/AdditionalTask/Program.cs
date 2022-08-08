/*
Дополнительное задание

Напишите программу для вычисления площади круга, прямоугольника и треугольника. Ввод данных 
осуществляется в диалоговом режиме. На первом шаге у пользователя запрашивается фигура, 
площадь которой нужно вычислить. На втором шаге пользователь вводит параметры, необходимые 
для рассчета. Затем, выводится результат.
*/

Console.WriteLine("Введите для какой фигуры нужно вычислить площадь: ");
Console.WriteLine("1 - круг");
Console.WriteLine("2 - прямоугольник");
Console.WriteLine("3 - треугольник");
int numFigure = int.Parse(Console.ReadLine());
double square = 0;
if (numFigure == 1)
{
    Console.WriteLine("Введите радиус: ");
    double radius = double.Parse(Console.ReadLine());
    square = 3.14*radius*radius;
} 
else if (numFigure == 2)
{
    Console.Write("Введите длину первой стороны: ");
    double sideLenght1 = double.Parse(Console.ReadLine());
    Console.Write("Введите длину второй стороны: ");
    double sideLenght2 = double.Parse(Console.ReadLine());
    square = sideLenght1*sideLenght2;
}
else if (numFigure == 3)
{
    Console.Write("Введите длину первой стороны: ");
    double sideLenght1 = double.Parse(Console.ReadLine());
    Console.Write("Введите длину второй стороны: ");
    double sideLenght2 = double.Parse(Console.ReadLine());
    Console.Write("Введите длину третьей стороны: ");
    double sideLenght3 = double.Parse(Console.ReadLine());
    double poluperimetr = (sideLenght1+sideLenght2+sideLenght3)/2;
    square = Math.Round(Math.Sqrt(poluperimetr*(poluperimetr-sideLenght1)*(poluperimetr-sideLenght2)*(poluperimetr-sideLenght3)));
}  
Console.Write("Площадь фигуры "+Math.Round(square,4));
