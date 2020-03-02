using System;

public class Kata
{
  public static int Litres(double time)
  {
    double water = 0.5d;
    double result = Math.Floor(water * time);
    
    return Convert.ToInt32(result);
  }
}