// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
//Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка

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
  Console.WriteLine("Вывод массива:");
  for (int i = 0; i < array.GetLength(0); i++)
  {
    for (int j = 0; j < array.GetLength(1); j++)
    {
      Console.Write(array[i, j] + " ");
    }
    Console.WriteLine();
  }
}

void minsum(int[,] array)
{
  int minsum = Int32.MaxValue;
  int indexLine = 0;
  for (int i = 0; i < array.GetLength(0); i++)
  {
    int sum = 0;
    for (int j = 0; j < array.GetLength(1); j++)
    {
      sum = sum + array[i, j];        
    }
    if (sum < minsum)
    {
      minsum = sum;
      indexLine++;
    }
  }
  Console.WriteLine($"номер строки с наименьшей суммой елементов = {indexLine} сумма елементов = {minsum}");
}

Console.Write("введите размер квадратного массива: ");
int n = Convert.ToInt32(Console.ReadLine());
int[,] numbers = new int[n, n];
FillArrayRandom(numbers);
PrintArray(numbers);
minsum(numbers);
