// Задача 58. Заполните спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 1  2  3  4
// 12 13 14 5
// 11 16 15 6
// 10  9  8  7

Console.Clear();

void Zadacha58()
{
    int m = 4;
    int n = 4;
    
    int[,] array = new int[m, n]; // 4 x 5
    
    SpiralFillArray(array, m, n);
    PrintArray(array);
    Console.WriteLine();    
}

void SpiralFillArray(int[,] array, int m, int n)
{
// Инициализация значения для заполнения матрицы
    int val = 1;
  
    // k - индекс начальной строки
    // m - индекс конечной строки
    // l - индекс начального столбца
    // n - индекс конечного столбца
    int k = 0, l = 0;
    while (k < m && l < n) {
        // Первый ряд из оставшихся рядов
        for (int j = l; j < n; j++)
        {
            array[k, j] = val++;
        }
        k++;
        // Последний столбец из оставшихся столбцов
        for (int i = k; i < m; i++)
        {
            array[i, n - 1] = val++;
        }
        n--;
  
        // Последний ряд из оставшихся рядов
        if (k < m)
        {
            for (int i = n - 1; i >= l; i--)
            {
                array[m - 1,i] = val++;
            }
            m--;
        }
  
        // Первый столбец из оставшихся столбцов
        if (l < n)
        {
            for (int i = m - 1; i >= k; i--)
            {
                array[i,l] = val++;
            }
            l++;
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

Zadacha58();