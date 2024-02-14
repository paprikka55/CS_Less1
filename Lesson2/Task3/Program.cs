Random rnd = new Random();
int[] digits = new int[10];
int index = 0;
while (index < digits.Length)
{
  digits[index] = rnd.Next(0, 100);
  if (digits[index] % 2 == 0)
  {
    Console.Write($"{digits[index]} ");
  }
  index++;
}

