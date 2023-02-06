// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9

double[,] CreateMatrixRndInt(int rows, int columns, double min, double max)
{
double[,] matrix = new double[rows, columns]; // 0, 1
Random rnd = new Random();

for (int i = 0; i < matrix.GetLength(0); i++)
{
for (int j = 0; j < matrix.GetLength(1); j++)
{
matrix[i, j] = rnd.NextDouble();
matrix[i, j] = Math.Round(matrix[i, j], 1, MidpointRounding.AwayFromZero);
}
}
return matrix;
}

void PrintMatrix(double[,] matrix)
{
for (int i = 0; i < matrix.GetLength(0); i++)
{
for (int j = 0; j < matrix.GetLength(1); j++)
{
if (j < matrix.GetLength(1) - 1) Console.Write($"{matrix[i, j], 4} ");
else Console.Write($"{matrix[i, j], 3} ");
}
Console.WriteLine();
}
}

double[,] array2D = CreateMatrixRndInt(3, 4, -100, 100);
PrintMatrix(array2D);

