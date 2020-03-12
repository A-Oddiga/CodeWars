using System;
public class Kata
{
  public static int DuplicateCount(string str)
  {
                        str = str.ToLower();
            string add = string.Empty;
            string remain = string.Empty;
            int extra = 0;
            for (int i = 0; i < str.Length; i++)
            {
                if (add.Contains(str[i]) == false)
                {
                    add += str[i];
                }
                else
                {
                    if(remain.Contains(str[i]) == false)
                    {
                        remain += str[i];
                        extra += 1;
                    }
                    
                }                           
            }
            return extra;
  }
}