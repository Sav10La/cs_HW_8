// Задача 54: Задайте двумерный массив. Напишите программу, которая
//упорядочит по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 2 4 1
// 9 5 3 2
// 8 4 4 2

Console.Clear();

void Zadacha54()
{
    int rows = 4;
    int columns = 5;
    
    int[,] array = new int[rows, columns]; // 4 x 5
    
    FillArray(array);
    PrintArray(array);
    Console.WriteLine();
    RowDescendingSort(array);
    PrintArray(array);    
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

void RowDescendingSort(int[,] array)
{
    int rows = array.GetLength(0);
    int columns = array.GetLength(1);
    for (int i = 0; i < rows; i++) // array.Length or array.GetLength(0)
    {
        for (int j = 0; j < columns; j++) // array.Length or array.GetLength(1)
        {
            for (int k = 0; k < columns - j - 1; k++)
            {
                if (array[i, k] > array[i, k + 1])
                {
                    int temp = array[i, k];
                    array[i, k] = array[i, k + 1];
                    array[i, k + 1] = temp;
                }
            }
        }
        Console.WriteLine();
    }
}

Zadacha54();