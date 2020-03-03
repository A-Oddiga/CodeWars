public static class Kata
{
  public static string RemoveUrlAnchor(string url)
  {
    string real = string.Empty;
    if(url.Contains('#'))
    {
      real = url.Remove(url.IndexOf('#'));
    }
    else
    {
      real = url;
    }
    return real;
  }
}