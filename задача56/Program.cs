// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, 
// которая будет находить строку с наименьшей суммой элементов.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт номер строки с 
// наименьшей суммой элементов: 1 строка

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
void FindMinSum(int[,] matrix)
{
    int minSum=int.MaxValue;
    int minRow=0;
    for (int j = 0; j < matrix.GetLength(0); j++)
    {
        int sumRows = 0;
        for (int i = 0; i < matrix.GetLength(1); i++)
        {
            sumRows += matrix[j, i];
        }
        int[] array = new int[j+1];
        array[j] =sumRows;
        // Console.Write(array[j] + "\t");
        if (array[j] < minSum)
        {
            minSum = array[j];
            minRow = Array.IndexOf(array,minSum)+1;
        }
        // Console.WriteLine($"Сумма каждой строки: {sumRows}");
    }
    // Console.WriteLine($"Минимальная сумма: {minSum}");
    Console.WriteLine($"Строка с наименьшей суммой элементов: {minRow}");
}
FindMinSum(array2D);