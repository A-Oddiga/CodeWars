using System;

public class NoBoring 
{
    public static int NoBoringZeros(int n) 
    {
    string k = "0";
    if(n.ToString().Length > 1)
    {
         k = n.ToString().Trim('0');
    }
    int j = Convert.ToInt32(k);
           
    return j;
    }
}