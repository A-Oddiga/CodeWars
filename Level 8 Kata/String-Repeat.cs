namespace Solution
{
  public static class Program
  {
    public static string repeatStr(int n, string s)
    {
   string cap = "";
    for(int i = 0; i < n; i++)
    {
      cap = cap + s;
    }
      return cap;
    }
  }
}