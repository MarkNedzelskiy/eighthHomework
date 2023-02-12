/*
Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
Например, даны 2 матрицы:
2 4 | 3 4
3 2 | 3 3
Результирующая матрица будет:
18 20
15 18
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

void PrintTwoMatrix (int[,] matrix1, int[,] matrix2)
{
    for (int i = 0; i < matrix1.GetLength(0); i++)
    {
    
        for (int j = 0; j < matrix1.GetLength(1); j++)
        {
            Console.Write($"{matrix1[i,j]} ");
        }

        Console.Write(" | ");

        for (int j = 0; j < matrix2.GetLength(1); j++)
        {
            Console.Write($"{matrix2[i,j]} ");
        }
    
        Console.WriteLine();
    }
}

void PrintMatrix (int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
    
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i,j]} ");
        }
    
        Console.WriteLine();
    }
}

int[,] MultiplyTwoMatrix (int[,] matrix1, int[,] matrix2)
{
    int[,] newMatrix = new int[2,2];

    newMatrix[0,0] = (matrix1[0,0] * matrix2[0,0]) + (matrix1[0,1] * matrix2[1,0]);
    newMatrix[0,1] = (matrix1[0,0] * matrix2[0,1]) + (matrix1[0,1] * matrix2[1,1]);
    newMatrix[1,0] = (matrix1[1,0] * matrix2[0,0]) + (matrix1[1,1] * matrix2[1,0]);
    newMatrix[1,1] = (matrix1[1,0] * matrix2[0,1]) + (matrix1[1,1] * matrix2[1,1]);

    return newMatrix;
}



int[,] matrix1 = InitMatrix(2, 2);
int[,] matrix2 = InitMatrix(2, 2);
PrintTwoMatrix(matrix1, matrix2);
Console.WriteLine();
int[,] matrix3 = MultiplyTwoMatrix(matrix1, matrix2);
PrintMatrix(matrix3);

