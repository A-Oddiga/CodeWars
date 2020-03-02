public class Kata
{
  public static string OddOrEven(int[] array)
  {
    int result = 0;
    string EorO = string.Empty;
    foreach(var item in array)
    {
      result += item;
    }
    if(result % 2 == 0)
    {
      EorO = "even";
    }
    else
    {
      EorO = "odd";
    }
    return EorO;
  }
}