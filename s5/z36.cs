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

int sumunevenmass(int[] array)
{
    int sum = 0;
    for (int i = 0; i <array.Length; i++ )
    {
      if (i % 2 == 1)
      {
        sum = sum + array[i];
      }
    }
  return sum;
}

Console.Write("Длина массива: ");
int n = Convert.ToInt32(Console.ReadLine());
int[] array = new int[n];

FillArray(array, -100, 100);
showmass(array);

int summ = sumunevenmass(array);
Console.WriteLine();
Console.WriteLine($"Сумма нечетных элементов массива: {summ}");