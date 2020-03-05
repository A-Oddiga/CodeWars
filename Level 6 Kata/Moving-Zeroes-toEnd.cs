using System;
using System.Collections.Generic;
using System.Linq;
public class Kata
{
  public static int[] MoveZeroes(int[] arr)
  {
    List<int> list = arr.ToList();
    for (int i = 0; i < arr.Length; i++)
     {
        if (arr[i].Equals(0))
         {
             list.Add(arr[i]);
             list.Remove(arr[i]);
          }
            }
     arr = list.ToArray();
     return arr;
  }
}