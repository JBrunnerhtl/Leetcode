namespace Reverse_Integer;

class Program
{
    public static void Main()
    {
        Console.WriteLine("Hello World!");
        Console.WriteLine(new Solution().Reverse(-123));
    }
}

public class Solution {
    public int Reverse(int x)
    {
        try
        {
            string intString = x.ToString();
            bool containsMinus = false;
            if (intString.Contains("-"))
            {
                intString = intString[1..];
                containsMinus = true;
            }
            intString = new string(intString.Reverse().ToArray());
            int newNum = int.Parse(intString);
            if(containsMinus) newNum*= -1;
            return newNum;
        }
        catch (Exception e)
        {
            return 0;
        }
        
    }
}