double coeff(string kb, string AB)
{
   Console.Write($"Введите коэффициент {kb} уравнения {AB}: ");
   double coeff = Convert.ToInt32(Console.ReadLine());
   return coeff;
}

void crossPoint(double k1, double k2, double b1, double b2)
{
  if (k1 == k2 && b1 == b2) 
  {
    Console.Write("Прямые совпадают");
  }
  else if (k1 == k2 && b1 != b2) 
  {
    Console.Write("Прямые параллельны");
  }
  else 
  {
    double x = (b2 - b1)/(k1 - k2);
    double y = k1 * x + b1;
    Console.Write($"Точка пересечения: {x}; {y}");
  }
}

double k1 = coeff("k", "1"); 
double k2 = coeff("k", "2");  
double b1 = coeff("b", "1"); 
double b2 = coeff("b", "2"); 

crossPoint(k1, k2, b1, b2);