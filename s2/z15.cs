Console.Write("день недели: ");
int d = Convert.ToInt32(Console.ReadLine());
switch (d)
{
    case 1: Console.WriteLine("понедельник"); break;
    case 2: Console.WriteLine("вторник"); break;
    case 3: Console.WriteLine("среда"); break;
    case 4: Console.WriteLine("четверг"); break;
    case 5: Console.WriteLine("пятница"); break;
    case 6: Console.WriteLine("суббота"); break;
    case 7: Console.WriteLine("воскресенье"); break;
  }

if (d < 1 || d > 7)
{
    Console.Write("попробуй снова");
}
 else 
 {
    if (d == 6 || d == 7)
    {
        Console.Write("выходной");
    }
    else
    {
        Console.Write("работать");
    }
 }