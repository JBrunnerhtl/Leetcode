namespace Palendrom;
class Program
{
    public static void Main()
    {
        Console.WriteLine("Hello World!");
    }
}
public class Solution {
    public bool IsPalindrome(int x)
    {
        string tmp = x.ToString();
        for (int i = 0, j = tmp.Length-1; i < tmp.Length; i++, j--)
        {
            if (tmp[i] != tmp[j])
            {
                return false;
            }
        }
        return true;
    }
}
