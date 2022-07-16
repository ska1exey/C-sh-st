void FillArray(int[] array, int min, int max)
{
  for (int i = 0; i<array.Length; i++ )
  {
    array[i] = new Random().Next(min, max);
  }
}

void showmass( int[]  mass)
{
    Console.Write("Вывод массива: ["); 
    foreach (var item in mass)
    {
        Console.Write(item + ", ");
    }
    Console.Write("\b\b"+"]");
}

int maxnumber( int[]  mass)
{
    int max = 0;
    for (int i = 0; i <mass.Length; i++ )
    {
      if (max < mass[i])
      {
        max = mass[i];
        }
    }
    return max;
}

int minnumber( int[]  mass)
{
    int min = 0;
    for (int i = 0; i <mass.Length; i++ )
    {
      if (min > mass[i])
      {
        min = mass[i];
        }
    }
    return min;
}

Console.Write("Длина массива: ");
int n = Convert.ToInt32(Console.ReadLine());
int[] array = new int[n];

FillArray(array, -100, 100);
showmass(array);
int max = maxnumber(array);
int min = minnumber(array);

int diff = max -min;
Console.WriteLine();
Console.WriteLine($"Разность max и min элементов массива: {diff}");
