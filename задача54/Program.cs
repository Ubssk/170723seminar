// Задача 54: Задайте двумерный массив. Напишите программу, 
// которая упорядочит по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2

Console.Write("Введите количество строк: ");
int rows = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество cтолбцов: ");
int columns = Convert.ToInt32(Console.ReadLine());
int minRandom = 0;
int maxRandom = 10;
int[,] array2D = GetMatrix(rows, columns, minRandom, maxRandom);
PrintMatrix(array2D);
int[,] GetMatrix(int m, int n, int min, int max)
{
    int[,] matrix = new int[m, n];
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = new Random().Next(min, max + 1);
        }
    }
    return matrix;
}
void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write(matrix[i, j] + "\t");
        }
        Console.WriteLine();
    }
}

void SelectionSort(int[,] matrix)
{
    for (int i = 0; i<matrix.GetLength(0); i++)
    {
        for (int j = 0; j<matrix.GetLength(1); j++)
        {
            int maxPosition2 =j;
            for (int k = j+1; k<matrix.GetLength(1); k++)
            {
                if(matrix[i,k]>matrix[i,maxPosition2])
                {
                    maxPosition2=k;
                }
            }
            int temporary=matrix[i,j];
            matrix[i,j] = matrix[i,maxPosition2];
            matrix[i,maxPosition2]=temporary;
        }
    }
}
SelectionSort(array2D);
Console.WriteLine("Массив по возрастанию в строке:");
PrintMatrix(array2D);