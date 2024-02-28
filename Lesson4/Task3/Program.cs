string GetLetters(string str)
{
  string letters = "";
  foreach(char e in str)
  {
    if (char.IsAsciiLetter(e) == true)
    {
      letters += e;
    }
  }
  return letters;
}


Console.Write("Введите строку: ");
string str = Console.ReadLine();
string result = GetLetters(str);
Console.WriteLine(result);