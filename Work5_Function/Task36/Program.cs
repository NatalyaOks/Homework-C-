/* Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
[3, 7, 23, 12] -> 19
[-4, -6, 89, 6] -> 0
*/
void PrintArray(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write(arr[i] + " ");
    }
}

void FillArray(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = new Random().Next(-100, 101);
    }
}

void SumOddElements(int[] arr)
{
    int sum = 0;
    for (int i = 1; i < arr.Length; i += 2)
    {
        sum += arr[i];
    }
    Console.WriteLine("Сумма нечетных элементов массива равна:" + sum); 
}

Console.Write("Введите количество элементов массива: ");
int n = int.Parse(Console.ReadLine());
int[] array = new int[n];

FillArray(array);
PrintArray(array);
Console.WriteLine();
SumOddElements(array);