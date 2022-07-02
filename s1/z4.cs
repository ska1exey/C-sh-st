Console.Write("a = ");
int a = Convert.ToInt32 (Console.ReadLine ());
Console.Write("b = ");
int b = Convert.ToInt32 (Console.ReadLine ());
Console.Write("c = ");
int c = Convert.ToInt32 (Console.ReadLine ());

Console.Write("max = ");
    if (a > b)
  {
	if (a > c)
{    
    Console.WriteLine (a);
	  }
	  else
	  {
	      Console.WriteLine (c);
	  }}
	  else
	  {
	    if (b > c)
{    
    Console.WriteLine (b);
	  }
	  else
	  {
	      Console.WriteLine (c);
	  }}