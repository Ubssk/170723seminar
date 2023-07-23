// Задача 58: Задайте две матрицы. Напишите программу, которая 
// будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

Console.Write("Введите количество строк: ");
int rows = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество cтолбцов: ");
int columns = Convert.ToInt32(Console.ReadLine());
int minRandom1 = 0;
int maxRandom1 = 10;
int[,] array2D1 = GetMatrix1(rows, columns, minRandom1, maxRandom1);
Console.WriteLine("Первая матрица:");
PrintMatrix1(array2D1);
int[,] GetMatrix1(int m, int n, int min, int max)
{
    int[,] matrix1 = new int[m, n];
    for (int i = 0; i < matrix1.GetLength(0); i++)
    {
        for (int j = 0; j < matrix1.GetLength(1); j++)
        {
            matrix1[i, j] = new Random().Next(min, max + 1);
        }
    }
    return matrix1;
}
void PrintMatrix1(int[,] matrix1)
{
    for (int i = 0; i < matrix1.GetLength(0); i++)
    {
        for (int j = 0; j < matrix1.GetLength(1); j++)
        {
            Console.Write(matrix1[i, j] + "\t");
        }
        Console.WriteLine();
    }
}
Console.WriteLine("Вторая матрица:");
int minRandom2 = 0;
int maxRandom2 = 10;
int[,] array2D2 = GetMatrix2(rows, columns, minRandom2, maxRandom2);
PrintMatrix2(array2D2);
int[,] GetMatrix2(int m, int n, int min, int max)
{
    int[,] matrix2 = new int[m, n];
    for (int i = 0; i < matrix2.GetLength(0); i++)
    {
        for (int j = 0; j < matrix2.GetLength(1); j++)
        {
            matrix2[i, j] = new Random().Next(min, max + 1);
        }
    }
    return matrix2;
}
void PrintMatrix2(int[,] matrix2)
{
    for (int i = 0; i < matrix2.GetLength(0); i++)
    {
        for (int j = 0; j < matrix2.GetLength(1); j++)
        {
            Console.Write(matrix2[i, j] + "\t");
        }
        Console.WriteLine();
    }
}
Console.WriteLine("Сумма матриц:");
int[,] arraySum = SumMatrix(rows, columns);
PrintSumMatrix(array2D1,array2D2,arraySum);
int[,] SumMatrix(int m, int n)
{
    int[,] matrix = new int[m, n];
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = new Random().Next();
        }
    }
    return matrix;
}
void PrintSumMatrix(int[,] matrix1,int[,] matrix2, int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = matrix1[i, j] + matrix2[i, j];
            Console.Write(matrix[i, j] + "\t");
        }
        Console.WriteLine();
    }
}