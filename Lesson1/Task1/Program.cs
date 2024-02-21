// Console.WriteLine("Hello world");
// int value = 100;
// Console.WriteLine(value);
// double d = 5.55;
// char c = '!';
// bool b = true;
// Console.WriteLine(b);
// Console.WriteLine(c);
// Console.WriteLine(d);

//true = 0
int main = 0;
int slave = 1;
if (main == 0 ^ slave == 0)
{
  if (main == 0)
  {Console.WriteLine("Main 0, Slave !0");}
  else
  {Console.WriteLine("Main !0, Slave 0");}
}
else
{
  if (main == 0)
  {Console.WriteLine("Main 0, Slave 0");}
  else
  {Console.WriteLine("Main !0, Slave !0");}
}
Console.WriteLine(true ^ true);    // output: False
Console.WriteLine(true ^ false);   // output: True
Console.WriteLine(false ^ true);   // output: True
Console.WriteLine(false ^ false);  // output: False