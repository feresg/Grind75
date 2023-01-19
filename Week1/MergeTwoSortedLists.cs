#nullable disable
namespace Week1;

public static class MergeTwoSortedLists
{
    public static ListNode MergeTwoLists(ListNode list1, ListNode list2)
    {
        if (list1 == null && list2 == null)
        {
            return null;
        }
        
        if (list1 == null)
        {
            return new ListNode(list2.val, MergeTwoLists(null, list2.next));
        }
        
        if (list2 == null)
        {
            return new ListNode(list1.val, MergeTwoLists(list1.next, null));
        }

        if (list1.val < list2.val)
        {
            return new ListNode(list1.val, MergeTwoLists(list1.next, list2));
        }

        return new ListNode(list2.val, MergeTwoLists(list1, list2.next));
    }

}

public class ListNode 
{
     public int val;
     public ListNode next;
     public ListNode(int val=0, ListNode next=null) 
     {
             this.val = val;
             this.next = next; 
     }
}
