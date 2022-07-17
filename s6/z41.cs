void Fillarray( int[]  mass)
{
    for (int i = 0; i < mass.Length; i++)
    {
        Console.Write($"Ввод {i+1} числа массива: ");
        mass [i] = Convert.ToInt32(Console.ReadLine());
    }
}

int count(int[] mass)
{
  int count = 0;
  for (int i = 0; i < mass.Length; i++)
  {
    if(mass[i] > 0 ) count += 1; 
  }
  return count;
}

Console.Write("Длина массива: ");
int n = Convert.ToInt32(Console.ReadLine());
int[] array = new int[n];

Fillarray(array);
Console.WriteLine($"Введено чисел больше 0: {count(array)} ");
