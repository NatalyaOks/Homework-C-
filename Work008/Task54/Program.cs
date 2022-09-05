/*Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию 
элементы каждой строки двумерного массива.

Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4

В итоге получается вот такой массив:
1 2 4 7
2 3 5 9
2 4 4 8 */

int[,] myArray = {
    {1,4,7,2},
    {5,9,2,3},
    {8,4,2,4}
};

PrintArray(myArray);

int tmp = 0;

Console.WriteLine("Упорядоченный массив:");
for (int i = 0; i < myArray.GetLength(0); i++)
{
    for (int j = 0; j < myArray.GetLength(1); j++)
    {
        for (int k = 0; k < myArray.GetLength(1) - 1 - j; k++)
        {
            if (myArray[i, k] > myArray[i, k+1])
            {
                tmp = myArray[i, k];
                myArray[i, k] = myArray[i, k+1];
                myArray[i, k+1] = tmp;
            }
        }
    }
}
PrintArray(myArray);

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
