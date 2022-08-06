// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
// и возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет

double[,] CreateMatrix(int m, int n)
{
  double[,] matrix = new double[m, n];
  for (int i = 0; i < m; i++)
  {
    for (int j = 0; j < n; j++)
    {
      Console.Write($"Введите число матрицы позиции ({i+1},{j+1}): ");
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

void SearchElement (double[,] array, int m, int n)
{
  Console.Write("Введите индексы числа, которое нужно найти: ");
  Console.WriteLine();
  Console.Write("Введите i: ");
  int i = Convert.ToInt32(Console.ReadLine())-1;
  Console.Write("Введите j: ");
  int j = Convert.ToInt32(Console.ReadLine())-1;
  if ( i < m && j < n)
  {
    Console.WriteLine($"Число: {array[i, j]}");
  }
  else
  Console.Write("Такого числа в матрице нет.");
}

Console.Write("Введите m: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите n: ");
int n = Convert.ToInt32(Console.ReadLine());

double [,] matrix = CreateMatrix(m, n);

WriteArray(matrix, m, n);
SearchElement(matrix, m, n);
