Random rnd = new Random();
int[] weight = new int[5];
int index = 0;
int max_weight = weight[0];
int max_index = 0;
while(index < weight.Length)
{
  weight[index] = rnd.Next(1, 36);
  if (weight[index] > max_weight)
  {
    max_weight = weight[index];
    max_index = index;
  }
  index++;
}
Console.WriteLine($"Максимальный вес гири: {max_weight}, гири под номером {max_index + 1}!");
max_weight = 0;
max_index = 0;

for(int i = 0; i < weight.Length; i++)
{
  if (weight[i] > max_weight)
  {
    max_weight = weight[i];
    max_index = i;
  }
}
Console.WriteLine($"Максимальный вес гири: {max_weight}, гири под номером {max_index + 1}!");

max_index = 0;
max_weight = 0;
foreach(int e in weight)
{
  if (e > max_weight)
  {
    max_weight = e;   
  }
}
Console.WriteLine($"Максимальный вес гири: {max_weight}!");