// Задачка дополнительная:
// 4 друга должны посетить 12 пабов, в котором выпить по британской пинте пенного напитка.
// До каждого бара идти 15-20 минут, каждый пьет пинту за 15 минут. У первого друга лимит выпитого 1.1 литра, 
// у второго 1.5, у третьего 2.2 литра, у 4 - 3.3 литра, это их максимум. Необходимо выяснить, 
// до скольки баров смогут дойти каждый из друзей(Пройденное расстояние (в барах)), пока не упадет. 
// И сколько всего времени будет потрачено на выпивку.

double[] FrendsLimit = new double[]{1.1, 1.5, 2.2, 3.3};
int TimeDrink = 15;
int[] TimeSpeed = new int[]{15, 20};
int Time = 0;
int PubsQuantity = 12;
double pint = 0.568;
int timeСounter = 0;

for (int i = 0; i <= FrendsLimit.Length - 1; i++)
{
  int count = 0;
  Time = -17;
  
  while (FrendsLimit[i] > 0)
  {
    FrendsLimit[i] -= pint;
    count++;
    Time = Time + new Random().Next(TimeSpeed[0], TimeSpeed[1] + 1);
  }

  timeСounter = Time + TimeDrink * count;
  
  if (count > PubsQuantity) Console.WriteLine($"Друг № {i + 1} пошел на 2-й круг и упадёт в {count-12} баре через {timeСounter / 60} часов {timeСounter % 60} минут");
  else 
  {
  Console.WriteLine($"Друг № {i + 1} упадёт в {count} баре через {timeСounter / 60} часов {timeСounter % 60} минут");
  }
}