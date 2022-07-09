Console.Write("число N: ");
int N = Convert.ToInt32(Console.ReadLine());
int i = 1;
Console.Write("Введите степень: ");
int X = Convert.ToInt32(Console.ReadLine());
Console.Write("Таблица чисел от 1 до N в степени X: ");
while (i <= N)
{
    double s = Math.Pow(i, X);
   Console.Write(s+", ");
    i += 1;
}
Console.Write("\b \b");

