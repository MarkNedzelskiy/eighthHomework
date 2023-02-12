/*
Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
В итоге получается вот такой массив:
7 4 2 1
9 5 3 2
8 4 4 2
*/

int [,] InitMatrix (int row, int column)
{
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

void SortFromHighToLow (int[,] matrix)
{
    int temp;
    int jComparsion;

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            
            if (i == 0 && j == 0) 
            {
                continue;
            }
            
            jComparsion = 0;

            while (jComparsion < j)
            {
            
                if (matrix[i, j] > matrix[i, jComparsion])
                {
                temp = matrix[i, jComparsion];
                matrix[i, jComparsion] = matrix[i,j];
                matrix[i,j] = temp;    
                }

            jComparsion++;
            }
        }
    }
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

int row = GetNumber("Введите количество строк:");
int column = GetNumber("Введите количество столбцов:");
int[,] matrix = InitMatrix(row, column);
PrintMatrix(matrix);
SortFromHighToLow(matrix);
Console.WriteLine();
PrintMatrix(matrix);