/*Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое 
элементов в каждом столбце.

Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4*/

int[,] array = { {1, 4, 7, 2 },
                 {5, 9, 2, 3 },
                 {8, 4, 2, 4 }
            };

double sum = 0;
double average = 0;

for (int i = 0; i < array.GetLength(1); i++)
{
    for (int j = 0; j < array.GetLongLength(0); j++)
    {
        sum += array[j, i];
    }
    average = sum / array.GetLength(0);
    sum = 0;
    Console.WriteLine($"среднеарифметическое значение столбца {i + 1} = " + Math.Round(average,2));
}