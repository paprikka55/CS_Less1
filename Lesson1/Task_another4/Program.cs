using System;

public class Answer
{
  static void PrintEvenNumbers(int number)
  {
    // Введите свое решение ниже
    int index = 1;
    int rem = 0;
    while (index <= number)
    {
      rem = index % 2;
      if (rem == 0)
      {
        Console.Write(index + " ");
      }
      index++;
    }
  }


  // Не удаляйте и не меняйте метод Main! 
  static public void Main(string[] args)
  {
    int number;

    if (args.Length >= 1)
    {
      number = int.Parse(args[0]);
    }
    else
    {
      // Здесь вы можете поменять значения для отправки кода на Выполнение
      number = 102;
    }

    // Не удаляйте строки ниже
    PrintEvenNumbers(number);
  }
}
      