Random rnd = new Random();
int[] weight = new int[5];
int index = 0;
int max_weight = weight[0];
int max_index = 0;
while (index < weight.Length)
{
  weight[index] = rnd.Next(0, 36);
  if (weight[index] > max_weight)
  {
    max_weight = weight[index];
    max_index = index;
  }
  index++;
}
Console.WriteLine($"Максимальный вес гири: {max_weight}, гири под номером {max_index + 1}!");