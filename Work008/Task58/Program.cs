/*Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение 
двух матриц.
Например, заданы 2 массива:

1 4 7 2
5 9 2 3
8 4 2 4
5 2 6 7
и
1 5 8 5
4 9 4 2
7 2 2 6
2 3 4 7

Их произведение будет равно следующему массиву:
1 20 56 10
20 81 8 6
56 8 4 24
10 6 24 49*/
Console.WriteLine("Матрица 1:");
int[,] array1 = {
    { 1, 4, 7, 2 },
    { 5, 9, 2, 3 },
    { 8, 4, 2, 4 },
    { 5, 2, 6, 7}
};
PrintArray(array1);

Console.WriteLine("Матрица 2:");
int[,] array2 = {
    { 1, 5, 8, 5 },
    { 4, 9, 4, 2 },
    { 7, 2, 2, 6 },
    { 2, 3, 4, 7}
};
PrintArray(array2);

Console.WriteLine("\n Произведение матриц:");

int[,] multiplicationArray = new int[array1.GetLength(0), array2.GetLength(1)];
{
    for (int i = 0; i < array1.GetLength(0); i++)
    {
        for (int j = 0; j < array2.GetLength(1); j++)
        {
            for (int k = 0; k < array2.GetLength(0); k++)
            {
                multiplicationArray[i, j] += array1[i, k] * array2[k, j];
            }
        }
    }
}

Console.WriteLine("\nРезультатом умножения является матрица:\n");

PrintArray(multiplicationArray);

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
