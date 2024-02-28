int GetFactorial(int number)
{
  int result = 0;
  if (number == 1 || number == 0)
  { 
    Console.WriteLine($"Stop: {number} ");
    return 1; 
  }
  //Console.WriteLine(number);
  result = number * GetFactorial(number - 1);
  Console.WriteLine($"N: {number}, !N: {result}");
  return result;
}
int num = 5;
Console.WriteLine($"!{num} = {GetFactorial(num)}");