using System;
  public class Sum
  {
     public int GetSum(int a, int b)
     {
            int value = 0;
            int low = 0;
            int high = 0;
            switch (a>b)
            {
                case true:
                    {
                        high = a;
                        low = b;
                        break;
                    }
                case false:
                    {
                        if (a == b)
                        {
                            value = a;
                        }
                        else
                        {
                            high = b;
                            low = a;
                        }
                        break;
                    }
            }     
            if(a != b)
            {
                for (int i = low; i <= high; i++)
                {
                    value += i;
                }
            }
       return value;
     }
  }