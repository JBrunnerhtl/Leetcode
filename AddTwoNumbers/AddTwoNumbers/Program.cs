using System.Numerics;

public class ListNode {
    public int val;
    public ListNode next;
    public ListNode(int val=0, ListNode next=null) {
        this.val = val;
        this.next = next;
     }
}

public class Program
{
    public static void Main()
    {
        ListNode l1 = new ListNode(1, new ListNode(2, new ListNode(3)));
        ListNode l2 = new ListNode(4, new ListNode(5));
        Solution sln = new Solution();
        var output = sln.AddTwoNumbers(l1, l2);
        Console.WriteLine(output); 
    }
}




 
public class Solution {
    public ListNode AddTwoNumbers(ListNode l1, ListNode l2)
    {
        string list1 = "";
        string list2 = "";
        ListNode head1 = l1;
        ListNode head2 = l2;
        while (head1 != null || head2 != null)
        {
            if (head1 != null)
            {
                list1 += head1.val.ToString();
                head1 = head1.next;    
            }

            if (head2 != null)
            {
                list2 += head2.val.ToString();
                head2 = head2.next;
            }
        }
        string reversed1 = new string(list1.Reverse().ToArray());
        string reversed2 = new string(list2.Reverse().ToArray());
        BigInteger sum = BigInteger.Parse(reversed1) + BigInteger.Parse(reversed2);
        
        char[] parts = sum.ToString().Reverse().ToArray();
        if (parts.Length > 0)
        {
            
            ListNode head = new ListNode(int.Parse(parts[0].ToString()));
            ListNode previous = head;
            for (int i = 1; i < parts.Length; i++)
            {
                ListNode newOne = new ListNode(int.Parse(parts[i].ToString()));
                previous.next = newOne;
                previous = newOne;
            }
            return head;
        }

        return new ListNode();

    }
}