using System;
public class Kata
{
  public static bool Narcissistic(int value)
  {
            bool isNarc = false;
            string val = value.ToString();
            double addit = 0;
            for (int i = 0; i < val.Length; i++)
            {
                int got = int.Parse(val[i].ToString());
                addit += Math.Pow(got, val.Length);
            }           
            if(addit == value)
            {
                isNarc = true;
            }
  
    return isNarc;
  }
}