double Exp(int a, int b)
{
    double result = Math.Pow(a, b);
    return result;
}

Console.Write("Введите число A: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число B: ");
int b = Convert.ToInt32(Console.ReadLine());

double exp = Exp(a, b);
Console.WriteLine($"Ответ: {exp}");