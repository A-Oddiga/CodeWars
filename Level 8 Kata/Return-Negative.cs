using System;

public static class Kata
{
  public static int MakeNegative(int number)
  {
   
  if(number.ToString().Contains("-"))
  {
    return number;
  }
    return -number;
  }
}