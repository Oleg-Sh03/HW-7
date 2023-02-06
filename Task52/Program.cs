// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

int[,] CreateMatrixRndInt(int rows, int columns, int min, int max)
{
int[,] matrix = new int[rows, columns]; // 0, 1
Random rnd = new Random();

for (int i = 0; i < matrix.GetLength(0); i++)
{
for (int j = 0; j < matrix.GetLength(1); j++)
{
matrix[i, j] = rnd.Next(min, max + 1);
}
}
return matrix;
}

void PrintMatrix(int[,] matrix)
{
for (int i = 0; i < matrix.GetLength(0); i++)
{
Console.Write("|");
for (int j = 0; j < matrix.GetLength(1); j++)
{
if (j < matrix.GetLength(1) - 1) Console.Write($"{matrix[i, j], 4} | ");
else Console.Write($"{matrix[i, j], 4} ");
}
Console.WriteLine("|");
}
}
int[,] array2D = CreateMatrixRndInt(3, 4, -100, 100);
PrintMatrix(array2D);


double[] ArithmeticMean(int[,] matrix)
{
double[] arr = new double[matrix.GetLength(1)];
int count = 0;
double x = matrix.GetLength(0);
for (int j = 0; j < matrix.GetLength(1); j++)
{   
    double sum = 0;
      for (int i = 0; i < matrix.GetLength(0); i++)
      {
        sum += matrix[i, j] / x;
        sum = Math.Round(sum, 1, MidpointRounding.AwayFromZero);
      }
 arr[count] = sum;
 count += 1;
}
return arr;
}
double[] mean = ArithmeticMean(array2D);

void PrintArray(double[] err)
{
  Console.Write("Среднее арифметическое каждого столбца: ");
for (int i = 0; i < err.Length; i++)
{
if(i < err.Length - 1) Console.Write($"{err[i]}; ");
else  Console.Write($"{err[i]}.");
}
}
PrintArray(mean);
