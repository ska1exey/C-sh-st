int x1 = Coordinate("x", "A");
int y1 = Coordinate("y", "A");
int z1 = Coordinate("z", "A");
int x2 = Coordinate("x", "B");
int y2 = Coordinate("y", "B");
int z2 = Coordinate("z", "B");

int Coordinate(string xyz, string AB)
{
    Console.Write($"Введите координату {xyz} точки {AB}: ");
    Convert.ToInt32(Console.ReadLine());
}
double L =  Math.Sqrt(Math.Pow((x2-x1), 2) + Math.Pow((y2-y1), 2) + Math.Pow((z2-z1), 2));
L = Math.Round(L, 2);
Console.WriteLine($"Расстояние:  {L}");