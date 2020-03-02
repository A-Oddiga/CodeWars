public class Kata
{
  public static string GetMiddle(string s)
  {
   string EorO = string.Empty;
   int half = 0;
   string middle = " ";
   if(s.Length % 2 == 0)
   {
     EorO = "even";
   }
   else
   {
     EorO = "odd";
   }
   if(EorO == "even")
   {
    half = s.Length / 2;
     middle = s[half-1].ToString() + s[half].ToString();
   }
   else
   {
     half = s.Length / 2;
     middle = s[half].ToString();
   }
   return middle;
  }
}