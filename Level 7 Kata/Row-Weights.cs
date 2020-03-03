class Kata
{
    public static int[] RowWeights(int[] a)
    {
        int[] teams = new int[] {0,0};
        int num = 0;
        for(int i = 0; i < a.Length; i++)
        {
          num += 1;
          if(num % 2 == 0 )
          {
            teams[1] += a[i];
          }
          else
          {
            teams[0] += a[i];
          }
        }
        return teams;
    }
}