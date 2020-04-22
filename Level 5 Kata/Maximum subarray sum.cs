using System;
using System.Collections.Generic;
using System.Linq;
public static class Kata
{
  public static int MaxSequence(int[] arr) 
  { 
            bool onlyNeg = false;
            bool onlyPos = false;
            int total = 0;
            List<int> list = new List<int>();
            if(arr.Length == 0)
            {
                total = 0;
            }
            else 
            {
                for (int i = 0; i < arr.Length; i++)
                {
                    if (arr[i].ToString().Contains('-'))
                    {
                        onlyNeg = true;
                    }
                    else
                    {
                        onlyNeg = false;
                        break;
                    }
                }
                for (int i = 0; i < arr.Length; i++)
                {
                    if (arr[i].ToString().Contains('-') == false)
                    {
                        onlyPos = true;;
                    }
                    else
                    {
                        onlyPos = false;
                        break;
                    }
                }
                if (onlyNeg == true)
                {
                    total = 0;
                }
                else if (onlyPos == true)
                {
                    foreach (var num in arr)
                    {
                        total += num;
                    }
                }
                else
                {
                    for (int i = 0; i < arr.Length; i++)
                    {
                        total = arr[i];
                        for (int k = 0; k < arr.Length; k++)
                        {
                            if (k > i)
                            {
                                total += arr[k];
                            }
                             list.Add(total);
                        }
                    }
                    total = list.Max();
                }
            }
           
           return total;
  }
}