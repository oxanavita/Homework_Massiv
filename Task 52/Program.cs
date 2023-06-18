// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

void FillArray (int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
        {
            for (int j = 0; j < array.GetLength(1); j++)
            {
                array[i, j] = new Random().Next(1,10); 
            }
        }
}

void PrintArray (int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
        {
            for (int j = 0; j < array.GetLength(1); j++)
            {
                Console.Write($"{array[i,j],2}    ");
            }
        Console.WriteLine();
        }
}

void ArithmeticMeanArray (int[,] array)
{
    int numRows = array.GetLength(0);
    int numCols = array.GetLength(1);

    double[] columnSums = new double[numCols];
    double[] columnMeans = new double[numCols];

    // Вычисление суммы элементов в каждом столбце
    for (int j = 0; j < numCols; j++)
    {
        for (int i = 0; i < numRows; i++)
        {
            columnSums[j] += array[i, j];
        }
    }

    // Вычисление среднего арифметического для каждого столбца
    for (int j = 0; j < numCols; j++)
    {
        columnMeans[j] = columnSums[j] / numRows;
    }

    // Вывод средних арифметических для каждого столбца
    Console.Write("Среднее арифметическое каждого столбца: ");
    for (int j = 0; j < numCols; j++)
    {
        Console.Write($"{columnMeans[j].ToString("F1"),3};     ");
    }
}


System.Console.Write("Введите количество строк: ");
int rows = Convert.ToInt32(Console.ReadLine());
System.Console.Write("Введите количество столбцов: ");
int cols = Convert.ToInt32(Console.ReadLine());
int [,] array = new int[rows, cols];
FillArray (array);
PrintArray (array);
ArithmeticMeanArray (array);