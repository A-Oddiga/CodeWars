using System;
public class Kata
{
  public static int Gimme(double[] inputArray)
  {
  double k = 0;
  var result = 0;
  double[] oldArray = new double[3];
  Array.Copy(inputArray, oldArray, 3);
  Array.Sort(inputArray);  
  k = inputArray[1];
  for(int i = 0; i < oldArray.Length; i++)
  {
    if(k == oldArray[i])
    {
       result = Array.IndexOf(oldArray, k);
    }
  }
  return (int)result;
  }
}