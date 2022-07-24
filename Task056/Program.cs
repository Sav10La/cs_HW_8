// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу,
//которая будет находить строку с наименьшей суммой элементов.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт номер
//строки с наименьшей суммой элементов: 1 строка

Console.Clear();

void Zadacha56()
{
    int rows = 4;
    int columns = 5;
    
    int[,] array = new int[rows, columns]; // 4 x 5
    
    FillArray(array);
    PrintArray(array);
    Console.WriteLine();
    MinSumRow(array);    
}

void FillArray(int[,] array)
{
    Random random = new Random();
    int rows = array.GetLength(0);
    int columns = array.GetLength(1);
    for (int i = 0; i < rows; i++) // array.Length or array.GetLength(0)
    {
        for (int j = 0; j < columns; j++) // array.Length or array.GetLength(1)
        {
            array[i, j] = random.Next(-10, 10);
        }
    }
}

void PrintArray(int[,] array)
{
    int rows = array.GetLength(0);
    int columns = array.GetLength(1);
    for (int i = 0; i < rows; i++) // array.Length or array.GetLength(0)
    {
        for (int j = 0; j < columns; j++) // array.Length or array.GetLength(1)
        {
            Console.Write(array[i, j] + "\t");
        }
        Console.WriteLine();
    }
}

int SumRow(int[,] array, int i)
{
    int rows = array.GetLength(0);
    int columns = array.GetLength(1);
    int sumRow = array[i, 0];
    for (int j = 1; j < columns; j++)
    {
        sumRow += array[i, j];
    }
    return sumRow;
}

void MinSumRow(int[,] array)
{
    int rows = array.GetLength(0);
    int columns = array.GetLength(1);
    int minSumRow = 0;
    int sumRow = SumRow(array, 0);
    for (int i = 1; i < rows; i++)
    {
        int temp = SumRow(array, i);
        if (sumRow > temp)
        {
            sumRow = temp;
            minSumRow = i;
        }
    }
    Console.WriteLine($"{minSumRow + 1} - строкa с наименьшей суммой элементов ({sumRow})");
}

Zadacha56();