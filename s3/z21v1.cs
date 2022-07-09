Console.Write($"Введите координату x точки A: ");
int x1 = Convert.ToInt32(Console.ReadLine());
Console.Write($"Введите координату y точки A: ");
int y1 = Convert.ToInt32(Console.ReadLine());
Console.Write($"Введите координату z точки A: ");
int z1 = Convert.ToInt32(Console.ReadLine());
Console.Write($"Введите координату x точки B: ");
int x2 = Convert.ToInt32(Console.ReadLine());
Console.Write($"Введите координату y точки B: ");
int y2 = Convert.ToInt32(Console.ReadLine());
Console.Write($"Введите координату z точки B: ");
int z2 = Convert.ToInt32(Console.ReadLine());

double L = Math.Sqrt(Math.Pow((x2-x1), 2) + Math.Pow((y2-y1), 2) + Math.Pow((z2-z1), 2));
L = Math.Round(L, 2);
Console.WriteLine($"Расстояние:  {L}");