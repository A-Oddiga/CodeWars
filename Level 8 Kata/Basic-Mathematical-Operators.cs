namespace Solution
{
  public static class Program
  {
    public static double basicOp(char operation, double value1, double value2)
    {
    double total = 0d;
     switch(operation)
     {
     case '+':
     {
      total = value1 + value2;
      break;
     }
       case '-':
     {
      total = value1 - value2;
      break;
     }
       case '*':
     {
      total = value1 * value2;
      break;
     }
       case '/':
     {
      total = value1 / value2;
      break;
     }
     }
      return total;
    }
  }
}