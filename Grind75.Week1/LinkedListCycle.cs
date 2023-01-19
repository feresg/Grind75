#nullable disable
using Grind75.Common;

namespace Week1;

public static class LinkedListCycle
{
    public static bool HasCycle(ListNode head)
    {
        var (slow, fast) = (head, head);

        while (fast?.next != null)
        {
            slow = slow.next;
            fast = fast.next.next;
            if (slow == fast) return true;
        }

        return false;
    }
}