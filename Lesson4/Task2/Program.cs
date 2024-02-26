int[,] CreateRandomDoubleArray(int rowCount, int ColCount)
{
  int[,] matrix = new int[rowCount, ColCount];
  Random rnd = new Random();
  for (int i = 0; i < matrix.GetLength(0); i++)
  {
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
      matrix[i, j] = rnd.Next(1, 1000);
    }
  }
  return matrix;
}

string ConvertDoubleArrayToString(int[,] matrix)
{
  string result = "";
  for (int i = 0; i < matrix.GetLength(0); i++)
  {
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
      result += $"{matrix[i, j]} ";
    }
    result += "\n";
  }
  return result;
}

string CheckSpecialNumbers(int[,] matrix)
{
  string SpecialNums = "";
  string result = "";
  int summ = 0;
  int special_count = 0;
  foreach (var el in matrix)
  {
    summ = GetSumOfDigits(el);
    if (summ % 2 == 0)
    {
      special_count++;
      SpecialNums += $"{el} ";
    }
  }
  result = $"Количество интересных чисел: {special_count}\nИнтересные числа: {SpecialNums}";
  return result;
}
int GetSumOfDigits(int number)
{
  int summ = 0;
  while(number > 0)
  {
    summ += number % 10;
    number /= 10; 
  }
  return summ;
}

int[,] matrix = CreateRandomDoubleArray(4, 5);
Console.WriteLine($"Массив:\n{ConvertDoubleArrayToString(matrix)}");
Console.WriteLine(CheckSpecialNumbers(matrix));
