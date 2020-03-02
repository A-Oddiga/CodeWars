public static class Kata
{
	public static int sumTwoSmallestNumbers(int[] numbers)
	{
   int total = 0;
   int first = int.MaxValue;
   int second = 0;
   for(int i = 0; i < numbers.Length; i++)
   {
     if(numbers[i] < first)
     {
     second = first;
     first = numbers[i];
     }
     else if (numbers[i] < second)
     {
       second = numbers[i];
     }
   }
    total = first + second;
    return total;
	}
}