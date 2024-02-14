int n = 10;
int[] arr = new int[n];
int index = 0;
while (index < arr.Length)
  {
    arr[index] = index + 1;
    Console.Write($"{arr[index]} ");
    index++;
  }