// Задача 50. Напишите программу, которая на вход принимает значение элемента в двумерном массиве, и возвращает позицию этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет

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
                Console.Write($"{array[i,j],3}    ");
            }
        Console.WriteLine();
        }
}

void SearchArray (int[,] array)
{
    Console.Write("Введите значение элемента: ");
    int target = int.Parse(Console.ReadLine());
    List<Tuple<int, int>> positions = new List<Tuple<int, int>>();
   
    // Поиск элемента в массиве
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (array[i, j] == target)
            {
               positions.Add(Tuple.Create(i, j));
            }
        }
    }        

    // Вывод результата
    if (positions.Count > 0)
    {
        Console.WriteLine("Элемент найден в следующих позициях:");
        foreach (var position in positions)
        {
            Console.WriteLine("({0}, {1})", position.Item1, position.Item2);
        }
    }
    else
    {
        Console.WriteLine("Такого элемента нет в массиве.");
    }
}


System.Console.Write("Введите количество строк: ");
int rows = Convert.ToInt32(Console.ReadLine());
System.Console.Write("Введите количество столбцов: ");
int cols = Convert.ToInt32(Console.ReadLine());
int [,] array = new int[rows, cols];
FillArray (array);
PrintArray (array);
SearchArray (array);