Console.Write("Длина массива:");
int n = Convert.ToInt32(Console.ReadLine());
int[] array = new int[n];


void Fillarray( int[]  mass)
{
    for (int i = 0; i < mass.Length; i++)
    {
        Console.Write($"Ввод {i+1} числа массива:");
        mass [i] = Convert.ToInt32(Console.ReadLine());
    }
}
void showmass( int[]  mass)
{
    Console.Write("Вывод массива: ["); 
    foreach (var item in mass)
    {
        Console.Write(item + ", ");
    }
    Console.Write("\b\b"+"]");
}

Fillarray(array);
showmass(array);

