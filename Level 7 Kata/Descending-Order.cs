using System;
using System.Collections.Generic;
public static class Kata
{
  public static int DescendingOrder(int num)
  {
        string strvalue = num.ToString();       
        List<char> list = new List<char>();
        for (int i = 0; i < strvalue.Length; i++)
         {
             list.Add(strvalue[i]);
         }
         list.Sort();
         list.Reverse();           
         strvalue = string.Empty;
        foreach (char item in list)
        {
            strvalue += item;
        }
         num = int.Parse(strvalue);
    
    return num;
  }
}