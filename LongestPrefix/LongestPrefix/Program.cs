namespace LongestPrefix;
class Program 
{
    public static void Main()
    {
        Console.WriteLine("Hello World!");
    }
}

public class Solution {
    public string LongestCommonPrefix(string[] strs)
    {
        string output = "";
        if(strs.Length == 0) return output;
        for (int i = 0; i < strs[0].Length; i++)
        {
            for (int j = 0; j < strs.Length; j++)
            {
                if (strs[j].Length <= i || strs[j][i] != strs[0][i])
                {
                    return output;
                }
                
            }
            output += strs[0][i];
        }
        return output;
    }
}