// See https://aka.ms/new-console-template for more information

var o = new Solution();
var output = o.FindMedianSortedArrays([1, 3], [2]);
Console.WriteLine(output);
public class Solution {
    public double FindMedianSortedArrays(int[] nums1, int[] nums2)
    {
        List<int> concatedArray = nums1.Concat(nums2).ToList();
        concatedArray.Sort();
        if (concatedArray.Count % 2 != 0)
        {
           
            return concatedArray[concatedArray.Count / 2];
        }

        double result = concatedArray[concatedArray.Count / 2] +  concatedArray[concatedArray.Count / 2 - 1];
        return result / 2;
    }
}