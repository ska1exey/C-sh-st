// Задача 62. Заполните спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 1 2 3 4
// 12 13 14 5
// 11 16 15 6
// 10 9 8 7

void CreateArray(int[,] numbers, int size)
{
  int num = 1;
  int i = 0;
  int j = 0;
  
  while (num <= size * size)
  {
    numbers[i, j] = num;
    if (i <= j + 1 && i + j < size - 1)
      ++j;
    else if (i < j && i + j >= size - 1)
      ++i;
    else if (i >= j && i + j > size - 1)
      --j;
    else
      --i;
    ++num;
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

Console.WriteLine("Введите размер квадратного массива");
int n = Convert.ToInt32(Console.ReadLine());
int[,] numbers = new int[n, n];
CreateArray(numbers, n);
PrintArray(numbers);