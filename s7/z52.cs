// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

double[,] CreateMatrix(int m, int n)
{
  double[,] matrix = new double[m, n];
  for (int i = 0; i < m; i++)
  {
    for (int j = 0; j < n; j++)
    {
      Console.Write($"Введите число матрицы позиции ({i},{j}): ");
      matrix [i, j] = Convert.ToInt32(Console.ReadLine());
    }
  }
  return matrix;
}

void WriteArray (double[,] array, int m, int n)
{
  Console.Write("Вывод матрицы: ");
  Console.WriteLine();
  for (int i = 0; i < m; i++)
  {
      for (int j = 0; j < n; j++)
      {
        Console.Write( Math.Round(array[i, j]) + " ");
      }
      Console.WriteLine();
  }
}

void ArithmeticMean (double[,] array, int m, int n)
{
  for (int i = 0; i < n; i++)
  {
    double ArithmeticMean = 0;
    for (int j = 0; j < m; j++)
    {
      ArithmeticMean += array[j, i];
    }
    ArithmeticMean = Math.Round(ArithmeticMean / m, 1);
    Console.Write($"Cреднее арифметическое столбца № {i+1} = {ArithmeticMean}");
    Console.WriteLine();
  }
}

Console.Write("Введите m: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите n: ");
int n = Convert.ToInt32(Console.ReadLine());

double [,] matrix = CreateMatrix(m, n);

WriteArray(matrix, m, n);
ArithmeticMean(matrix, m, n);