/*Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном 
массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.

Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
17 -> такого числа в массиве нет */

int[,] GetArray(int row, int col)
{
    int[,] array = new int[row, col];
    Random random = new Random();
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = random.Next(0, 10);
        }
    }
    return array;
}
void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + " ");
        }
        Console.WriteLine();
    }
}
Console.Write("Введите количество строк: ");
int row = int.Parse(Console.ReadLine());
Console.Write("Введите количество столбцов строк: ");
int col = int.Parse(Console.ReadLine());
int [,] arr = GetArray(row, col);
PrintArray(arr);
Console.WriteLine("Введите номер строки элемента");
int rowNum = int.Parse(Console.ReadLine());
Console.WriteLine("Введите номер столбца элемента");
int colNum = int.Parse(Console.ReadLine());
if (rowNum <= row & colNum <= col)
{
Console.WriteLine("Значение элемента с номером " + "[" + rowNum + "," + colNum + "]" + " = "+ arr[rowNum,colNum]);
}
else 
{
    Console.WriteLine("Элемента с таким номером нет в массиве");
}