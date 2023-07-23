// Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07

Console.Write("Введите размер матрицы: ");
int size =Convert.ToInt32(Console.ReadLine());
int[,] array=GetMatrix(size,size);
PrintMatrix(array);
int[,] GetMatrix(int m, int n)
{
    int[,] matrix = new int[m, n];
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i,j] = 0;
        }
    }                               
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            int a = i + 1;
            int b = j + 1;
            int switcher =  (b - a + size) / size;
            int Ic = Math.Abs(a - size / 2  - 1) + (a - 1) / (size /2) * ((size-1) % 2);
            int Jc = Math.Abs(b - size / 2  - 1) + (b - 1)/(size /2) * ((size-1) % 2);
            int Ring = size / 2 -  (Math.Abs(Ic - Jc) + Ic + Jc) / 2;
            int Xs = (a-Ring) + (b-Ring) - 1; 
            int Coef = size*size - (size - 2*Ring)*(size - 2*Ring);
            matrix[i,j] =  Coef + switcher * (Xs) + Math.Abs(switcher - 1) * (4 * (size - 2 * Ring) - 2 - Xs);
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