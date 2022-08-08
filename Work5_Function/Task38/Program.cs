/*Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и 
минимальным элементов массива.
[3 7 22 2 78] -> 76
*/
void PrintArray(double[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write(arr[i] + " ");
    }
}

void FillArray(double[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = new Random().Next(0, 100);
    }
}

void DifferenceMaxMin(double[] arr)
{
    double max = arr[0];
    double min = arr[0];
    double difference = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (max < arr[i])
        {
            max = arr[i];
        }
        if (min > arr[i])
        {
            min = arr[i];
        }
    }
    difference = max - min;
    Console.WriteLine("Разница между максимальным и минимальным элементом массива: " + difference);
}

Console.Write("Введите количество элементов массива: ");
int n = int.Parse(Console.ReadLine());
double[] array = new double[n];

FillArray(array);
PrintArray(array);
Console.WriteLine();
DifferenceMaxMin(array);