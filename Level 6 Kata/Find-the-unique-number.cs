using System.Collections.Generic;
using System.Linq;

public class Kata
{
  public static int GetUnique(IEnumerable<int> numbers)
  {
            int[] arr = numbers.ToArray();
            List<int> list = arr.ToList();
            int storeIt = 0;
            //Array will contain atleast 3 values
            if(arr[0] == arr[1])
            {
                for (int i = 0; i < arr.Length; i++)
                {
                    list.Remove(arr[0]);
                }
            }
            else if(arr[1] == arr[2] || arr[0] == arr[2])
            {
                for (int i = 0; i < arr.Length; i++)
                {
                    list.Remove(arr[2]);
                }
            }
            storeIt = list[0];
            return storeIt;
  }
}