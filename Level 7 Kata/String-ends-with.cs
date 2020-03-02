public class Kata
{
  public static bool Solution(string str, string ending)
  {
       bool Issending = false;
       if (str.EndsWith(ending))
       {
        Issending = true;
       }
       return Issending;
  }
}