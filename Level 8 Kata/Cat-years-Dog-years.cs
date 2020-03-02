public class Dinglemouse {

  public static int[] humanYearsCatYearsDogYears(int humanYears) {
    int catYears = 15;
    int dogYears = 15;
    if(humanYears >= 2)
    {
      catYears = catYears + 9;
      dogYears = dogYears + 9;
    }
    for(int i = 2; i < humanYears; i++)
    {
     catYears = catYears + 4;
      dogYears = dogYears + 5;
    }
    return new int[]{humanYears,catYears,dogYears};
  }

}