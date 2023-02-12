/*
Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.

Например, задан массив:

1 4 7 2

5 9 2 3

8 4 2 4

5 2 6 7

Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка
*/

int [,] InitRectangleMatrix ()
{
    int row, column;

    while (true)
    {
        row = GetNumber("Введите количество строк:");
        column = GetNumber("Введите количество столбцов:");
        if (row != column) break;
        else Console.WriteLine("Матрица должна быть прямоугольной!");
    }

    Random rnd = new Random();
    int[,] matrix = new int[row, column];

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i,j] = rnd.Next(0, 10);
        }
    }

    return matrix;
}

int GetNumber (string message)
{
    Console.WriteLine(message);
    
    int number = Convert.ToInt32(Console.ReadLine());

    return number;
}

void PrintMatrix (int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
    
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i,j]} | ");
        }
    
    Console.WriteLine();
    }
}

void FindMinRowSumm (int[,] matrix)
{
    int minSumm = 0; 
    int summCheck;
    int minSummRow = 1;

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        summCheck = 0;

        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            summCheck += matrix[i,j];
        }

        if (i == 0) minSumm = summCheck;
        else
        {
            if (summCheck < minSumm) 
            {
                minSummRow = i + 1;
                minSumm = summCheck;
            }
        }
    }
    
    Console.WriteLine($"{minSummRow} строка");
}

int[,] matrix = InitRectangleMatrix();
PrintMatrix(matrix);
Console.WriteLine();
FindMinRowSumm(matrix);