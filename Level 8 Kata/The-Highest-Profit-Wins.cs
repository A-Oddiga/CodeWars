using System;
using System.Linq;
public class MinMax 
{
    public static int[] minMax(int[] lst) 
    {      
        int low = lst.Min();        
        int high =  lst.Max();       
        return new int[]{low,high};
    }
}