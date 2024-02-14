Random rnd = new Random();
int[] weight = new int[5];
for (int j = 0; j < weight.Length; j++)
{
  weight[j] = rnd.Next(1, 32);
}
int max_weight = weight[0];
int max_index = 0;
for (int i = 0; i < weight.Length; i++)
{
  if (weight[i] > max_weight)
  {
    max_weight = weight[i];
    max_index = i;
  }
}
Console.WriteLine($"Максимальный вес гири: {max_weight}, гири под номером {max_index + 1}!");