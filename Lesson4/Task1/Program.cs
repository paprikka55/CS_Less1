int[,] CreateRandomDoubleArray(int rowCount, int ColCount)
{
  int[,] matrix = new int[rowCount, ColCount];
  Random rnd = new Random();
  for (int i = 0; i < matrix.GetLength(0); i++)
  {
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
      matrix[i, j] = rnd.Next(1, 11);
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

int[,] matrix = CreateRandomDoubleArray(4, 5);
Console.WriteLine(ConvertDoubleArrayToString(matrix));
