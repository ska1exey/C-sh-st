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

int evennumbers(int[] array)
{
    int evenn = 0;
    for (int i = 0; i<array.Length; i++ )
    {
        if (array[i] % 2 == 0)
        {
            evenn++;
        }
    }
  return evenn;
}

Console.Write("Длина массива: ");
int n = Convert.ToInt32(Console.ReadLine());
int[] array = new int[n];

Console.Write("Количество знаков: ");
int d = Convert.ToInt32(Console.ReadLine());
int min = 1;
int max = 10;

for (int j = 1; j<d; j++ )
{
    min = min * 10;
    max = max * 10;
}


FillArray(array, min, max);
showmass(array);

int evenn = evennumbers(array);
Console.WriteLine();
Console.WriteLine($"Количество чётных чисел: {evenn}");
