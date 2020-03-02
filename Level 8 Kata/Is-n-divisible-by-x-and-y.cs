public class DivisibleNb {
	public static bool isDivisible(long n, long x, long y) {
  bool isit = false;
		if (n % x == 0 && n % y == 0)
    {
      isit = true;
    }
    else
    {
      isit = false;
    }
    return isit;
	}
}