void FillArray(int[] arr)
{
  for (int i = 0; i < arr.Length; i++)
  { 
    arr[i] = new Random().Next(1, 100); 
    // arr[i] = i + 1;
  }
}

void PrintArray(int[] arr)
{
  for (int i = 0; i < arr.Length; i++)
  { 
    if (i + 1 == arr.Length)
    Console.WriteLine($"{arr[i]}");
    else
    Console.Write($"{arr[i]} "); 
  }
}

int GetSumOfElements(int[] arr)
{
  int summ = 0;
  for (int i = 0; i < arr.Length; i++)
  { summ += arr[i]; }
  return summ;
}

int GetProductOfElements(int[] arr)
{
  int prod = 1;
  for (int i = 0; i < arr.Length; i++)
  { prod = prod * arr[i]; }
  return prod;
}

int n = 10;
int[] arr = new int[n];
FillArray(arr);
PrintArray(arr);
int sum = GetSumOfElements(arr);
int product = GetProductOfElements(arr);
Console.WriteLine(sum);
Console.WriteLine(product);