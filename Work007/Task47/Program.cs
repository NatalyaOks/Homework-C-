/*Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными 
числами.

m = 3, n = 4.
0,5 7 -2 -0,2
1 -3,3 8 -9,9
8 7,8 -7,1 9 */

double[,] GetArray(int row, int col)
{
    double[,] array = new double[row, col];
    Random random = new Random();
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = random.NextDouble()*100-50;
        }
    }
    return array;
}

void PrintArray(double[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(Math.Round(array[i, j], 2) + "\t");
        }
        Console.WriteLine();
    }
}

Console.WriteLine("Введите количество строк: ");
int row = int.Parse(Console.ReadLine());
Console.WriteLine("Введите количество столбцов: ");
int col = int.Parse(Console.ReadLine());
PrintArray(GetArray(row, col));
