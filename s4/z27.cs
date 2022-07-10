Console.Write("Введите число: ");
int a = Convert.ToInt32(Console.ReadLine());

  int SumN(int a)
  {
    int c = Convert.ToString(a).Length;
    int adv = 0;
    int result = 0;

    for (int i = 0; i < c; i++){
      adv = a - a % 10;
      result = result + (a - adv);
      a = a / 10;
    }
   return result;
  }

int sum = SumN(a);
Console.WriteLine($"Сумма цифр в числе: {sum}");