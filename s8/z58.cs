// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, заданы 2 массива:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// и
// 1 5 8 5
// 4 9 4 2
// 7 2 2 6
// 2 3 4 7
// Их произведение будет равно следующему массиву:
// 1 20 56 10
// 20 81 8 6
// 56 8 4 24
// 10 6 24 49

void FillArrayRandom(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(0, 10);
        }
    }
}

void PrintArray(int[,] array)
{
  for (int i = 0; i < array.GetLength(0); i++)
  {
    for (int j = 0; j < array.GetLength(1); j++)
    {
      Console.Write(array[i, j] + " ");
    }
    Console.WriteLine();
  }
}

void DerMatrix(int[,] matrixA, int[,] matrixB, int[,] matrixC, int n)
{
  for (int i = 0; i < n; i++)
  {
    for (int j = 0; j < n; j++)
    {
      for (int k = 0; k < n; k++)
      {
        matrixC[i, j] = matrixC[i, j] + (matrixA[i, k] * matrixB[k, j]);
      }
    }
  }
}

Console.Write("введите размер квадратных матриц: ");
int n = Convert.ToInt32(Console.ReadLine());

int[,] matrixA = new int[n, n];
int[,] matrixB = new int[n, n];
int[,] matrixC = new int[n, n];

FillArrayRandom(matrixA);
FillArrayRandom(matrixB);

Console.WriteLine("Матрица - А:");
PrintArray(matrixA);
Console.WriteLine();
Console.WriteLine("Матрица - В:");
PrintArray(matrixB);
Console.WriteLine();

Console.WriteLine("Произведение матриц А*В:");
DerMatrix(matrixA, matrixB, matrixC, n);
PrintArray(matrixC);