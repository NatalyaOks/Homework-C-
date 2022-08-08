/* Задача 37: Найдите произведение пар чисел в одномерном массиве. Парой считаем первый и 
последний элемент, второй и предпоследний и т.д. Результат запишите в новом массиве.
[1 2 3 4 5] -> 5 8 3
[6 7 3 6] -> 36 21
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
        arr[i] = new Random().Next(0, 10);
    }
}

void CompositionNum(int[] arr)
{
    int size = arr.Length;
    int[] composit = new int[size];
    for (int i = 0; i < size; i++)
    {
        for (int j = 0; j < size; j++)
        {
            if (i < size-1)
            {
                composit[j] = arr[i] * arr[size - 1];
            }
            else
            {
                composit[j] = arr[i]*1;
            }
            size--;
            i++;
            Console.Write(composit[j] + " ");
        }
    }
}

Console.Write("Введите количество элементов массива: ");
int n = int.Parse(Console.ReadLine());
int[] array = new int[n];

FillArray(array);
PrintArray(array);
Console.WriteLine();
CompositionNum(array);