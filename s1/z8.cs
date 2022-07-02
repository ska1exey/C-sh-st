Console.Write("N = ");
int N = Convert.ToInt32 (Console.ReadLine ());
int a = 0;
Console.Write("все чётные числа : "); 
if (N % 2 == 0)
{
 while (a < N) 
 { 
     a = a + 2;
 Console.Write(a);
 Console.Write(" ");
}}
else
{
 while (a + 1 < N) 
 { 
     a = a + 2;
 Console.Write(a);
 Console.Write(" ");
}}