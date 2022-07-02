Console.Write("число: ");
int a = Convert.ToInt32(Console.ReadLine());
string st = Convert.ToString(a);
int i = 0;
Console.Write("номер цифры числа, которую нужно найти: ");
int n = Convert.ToInt32(Console.ReadLine());
while (i + 1 < n)
{
    i += 1;
}
Console.WriteLine(n+" цифра этого числа = "+st[i]);