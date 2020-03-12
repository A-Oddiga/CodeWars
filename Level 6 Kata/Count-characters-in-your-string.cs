using System;
using System.Collections.Generic;

public class Kata
{
  public static Dictionary<char, int> Count(string str)
  {
           Dictionary<char, int> charCount = new Dictionary<char, int>();
            foreach (var item in str)
            {
                try
                {
                    charCount.Add(item, 1);
                }
                catch
                {
                    charCount[item] += 1;
                }
            }
            return charCount;
  }
}