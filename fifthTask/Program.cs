/*
Напишите программу, которая заполнит спирально массив 4 на 4.
Например, на выходе получается вот такой массив:
01 02 03 04
12 13 14 05
11 16 15 06
10 09 08 07
*/


/*
Упоротый метод, слишком загруженный, но пока единственный рабочий вариант, который я закончил.
В нем я задаю границы по строкам и столбцам, булевыми значениями задаю направление присваивания, 
и постепенно уменьшая границы. Из плюсов, работает с матрицами любого размера, ну и что сам полностью придумал.
Теперь полезу гуглить другие варианты решения...
*/
int [,] InitMatrix (int row, int column)
{
    int[,] matrix = new int[row, column];
    int value = 1;
    int rowMinBound = 0;
    int rowMaxBound = row - 1;
    int columnMinBound = 0;
    int columnMaxBound = column - 1;
    
    bool columnPlusDirection = true;
    bool rowPlusDirection = false;
    bool columnMinusDirection = false;
    bool rowMinusDirection = false;
    
    while (value <= row * column)    
    {
        if (columnPlusDirection)
        {
            for (int i = columnMinBound; i <= columnMaxBound; i++)
            {
                matrix[rowMinBound, i] = value;
                value++;
            }
            rowMinBound++;
            columnPlusDirection = false;
            rowPlusDirection = true;
            continue;
        }
        if (rowPlusDirection)
        {
            for (int i = rowMinBound; i <= rowMaxBound; i++)
            {
                matrix[i, columnMaxBound] = value;
                value++;
            }
            columnMaxBound--;
            rowPlusDirection = false;
            columnMinusDirection = true;
            continue;
        }
        if (columnMinusDirection)
        {
            for (int i = columnMaxBound; i >= columnMinBound; i--)
            {
                matrix[rowMaxBound, i] = value;
                value++;
            }
            rowMaxBound--;
            columnMinusDirection = false;
            rowMinusDirection = true;
            continue;
        }
        if (rowMinusDirection)
        {
            for (int i = rowMaxBound; i >= rowMinBound; i--)
            {
                matrix[i, columnMinBound] = value;
                value++;
            }
            columnMinBound++;
            rowMinusDirection = false;
            columnPlusDirection = true;
            continue;
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
            Console.Write($"{matrix[i,j]} ");
        }
    
    Console.WriteLine();
    }
}


int row = GetNumber("Введите количество строк:");
int column = GetNumber("Введите количество столбцов:");
int[,] matrix = InitMatrix(row, column);
PrintMatrix(matrix);