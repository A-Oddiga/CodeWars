public class Triangle
{
    public static bool IsTriangle(int a, int b, int c)
    {
    bool Istri = false;
    int k = a+b;
    int i = a+c;
    int j = b+c;
    if(k > c && i > b && j > a)
    {
    Istri = true;
    } 
    return Istri;       
    }
}