Console.Write("Введите пятизначное число: ");
string a = Convert.ToString(Console.ReadLine());
if (a.Length == 5)
{
  if (a[0] == a[4] && a[1] == a[3])
  {
    Console.WriteLine($"Ваше число: {a} - палиндром.");
  }
  else Console.WriteLine($"Ваше число: {a} - не палиндром.");
}
else 
{
    Console.WriteLine("Попробуй ещё");   
}