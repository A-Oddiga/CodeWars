public static class Kata
{
  public static int CountSmileys(string[] smileys) 
  {
  int smiles = 0;  
  for(int i = 0; i < smileys.Length;i++)
  {
    string k = smileys[i].ToString().Trim();
     if(k.Contains(":") || k.Contains(";"))
    {
      if(k.Contains("") || k.Contains("-") || k.Contains("~"))
      {
        if(k.Contains(")") || k.Contains("D"))
        { 
          smiles++;
          if (k.Contains(" "))
          {
            smiles -=1;
          }
        }
      }  
    }   
  }
     return smiles;
  }
}
