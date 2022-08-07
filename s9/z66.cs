//Задача 66: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9

int InputInt(string input)
{
  Console.Write(input);
  return Convert.ToInt32(Console.ReadLine());
}

int Akkerman(int m, int n)
{
  if (m == 0)
    return n + 1;
  if (m > 0 && n == 0)
    return Akkerman(m - 1, 1);
  else
    return Akkerman(m - 1, Akkerman(m, n - 1));
}

Console.WriteLine("Введите два положительных числа: M и N.");
int m = InputInt("Введите M: ");
int n = InputInt("Введите N: ");

Console.WriteLine($"A({m}, {n}) = {Akkerman(m, n)}");