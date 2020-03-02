public class Kata
{
  public static string Sabb(string x, int val, int happ)
  {
  int gotit = 0;
     for(int i = 0; i < x.Length; i++)
     {
      if(x[i] == 's' || x[i] == 'S' || x[i] == 'a' || x[i] == 'A' || x[i] == 'b' || x[i] == 'B' || x[i] == 't' || x[i] == 'T'|| x[i] == 'i' || x[i] == 'I'|| x[i] == 'c' || x[i] == 'C'|| x[i] == 'l' || x[i] == 'L') gotit++;
     }
           
            if (  gotit + val + happ > 22)
            {
                return "Sabbatical! Boom!";

            }
            else
            {
                return "Back to your desk, boy.";
            }
  }
}