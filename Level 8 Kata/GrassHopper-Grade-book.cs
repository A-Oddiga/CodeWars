using System;

public class Kata
{
  public static char GetGrade(int s1, int s2, int s3)
  {
  char grade = 'A';
    int total = s1 + s2 + s3;
    int totalDiv = total / 3;
    
    if (totalDiv >= 90) grade = 'A';
    else if (totalDiv >= 80)  grade = 'B';
    else if (totalDiv >= 70)  grade = 'C';
    else if (totalDiv >= 60)  grade = 'D';
    else if (totalDiv < 60)  grade = 'F';
    return grade;
  }
}