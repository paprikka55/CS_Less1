Console.Write("Введите целое число a: ");
string str_a = Console.ReadLine();
Console.Write("Введите целое число b: ");
string str_b = Console.ReadLine();
Console.Write("Введите целое число c: ");
string str_c = Console.ReadLine();
Console.Write("Введите целое число d: ");
string str_d = Console.ReadLine();
int a = 0;
int b = 0;
int c = 0;
int d = 0;
try 
{
  a = Convert.ToInt32(str_a);
  b = Convert.ToInt32(str_b);
  c = Convert.ToInt32(str_c);
  d = Convert.ToInt32(str_d);
}
catch
{
  Console.WriteLine("Вы ввели не целое число!");
}
finally
{
  float result = (Convert.ToSingle(a) * b) / (c + d);
  Console.WriteLine("Результат: " + result);
}