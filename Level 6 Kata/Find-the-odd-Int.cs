namespace Solution
{
  class Kata
    {
    public static int find_it(int[] seq) 
      {
      int odd = 0;
            for (int i = 0; i < seq.Length; i++)
            {
                int total = 0;
                foreach (var item in seq)
                {                    
                    if(item == seq[i])
                    {
                        total += 1;
                    }                                                                                  
                }
                if (total % 2 != 0)
                {
                    odd = seq[i];
                }
            }
      return odd;
      }      
    }
}