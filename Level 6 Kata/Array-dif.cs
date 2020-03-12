using System.Collections.Generic;
using System.Collections;
using System.Linq;
public class Kata
{
  public static int[] ArrayDiff(int[] a, int[] b)
  {
            List<int> list = a.ToList();
            if (b.Length == 0)
            {

            }
            else
            {
                for (int i = 0; i < a.Length; i++)
                {
                    for (int k = 0; k < b.Length; k++)
                    {
                        if (a[i].Equals(b[k]))
                        {
                            list.Remove(a[i]);
                        }
                    }
                  
                }
            }

            int[] newArr = list.ToArray();
            return newArr;
  }
}