using System;
public class Kata
{
  public static int[] TwoSum(int[] numbers, int target)
  {
            int value1 = 0;
            int value2 = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                int helper = 0;
                for (int k = 0; k < numbers.Length; k++)
                {                   
                    do
                    {                      
                        if (numbers[i] + numbers[k] == target) 
                        {
                            value1 = Array.IndexOf(numbers,numbers[i]);
                            value2 = Array.LastIndexOf(numbers,numbers[k]);
                        }
                        helper += 1;
                    } while (helper < numbers.Length );                  
                }
            }
      int[] arr = new int[] {value1, value2};
    return arr;
  }
}