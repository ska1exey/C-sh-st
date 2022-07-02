Console.Write("число: ");
int a = Convert.ToInt32(Console.ReadLine());
string st = Convert.ToString(a);
int i = 0;
Console.Write("номер цифры числа, которую нужно найти: ");
int n = Convert.ToInt32(Console.ReadLine());
if (n > 0)
{
    if (st.Length > n - 1)
{
    while (i + 1 < n)
{
    i += 1;
    }
Console.WriteLine(n+" цифра этого числа = "+st[i]);
}
else
{
    Console.WriteLine(" такого числа нет ");
}
}
else
{
    Console.WriteLine(" Error 33333 ");
    }
