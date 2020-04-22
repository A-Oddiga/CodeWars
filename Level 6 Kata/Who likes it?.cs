using System;

public static class Kata
{
  public static string Likes(string[] name)
  {
            string gen = " like this";
            string formatted = string.Empty;
            if (name.Length < 1)
            {
                formatted = "no one likes this";
            }
            else if (name.Length == 1)
            {
                formatted = $"{name[0]} likes this";
            }
            else if (name.Length == 2)
            {
                formatted = $"{name[0]} and {name[1]}" + gen;
            }
            else if (name.Length == 3)
            {
                formatted = $"{name[0]}, {name[1]} and {name[2]}" + gen;
            }
            else if(name.Length >= 4)
            {
                formatted = $"{name[0]}, {name[1]} and {name.Length - 2} others" + gen;
            }
            return formatted;
  }
}
