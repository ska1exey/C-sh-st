// Задача 64: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

int InputInt(string input)
{
  Console.Write(input);
  return Convert.ToInt32(Console.ReadLine());
}


int CountNaturalSum(int m, int n)
{
  if (m == n)
    return n;
  return n + CountNaturalSum(m, n - 1);
}

int n = InputInt("Введите n: ");
int m = InputInt("Введите m: ");
int temp = m;

if (m > n) 
{
  m = n; 
  n = temp;
}

Console.WriteLine($"Сумма элементов от {m} до {n} = {CountNaturalSum(m, n)}");
