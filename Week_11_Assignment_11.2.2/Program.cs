

namespace Week_11_Assignment_11._2._2
{
    using System;

    public class ListNode
    {
        public int val;
        public ListNode next;
        public ListNode(int val = 0, ListNode next = null)
        {
            this.val = val;
            this.next = next;
        }
    }

    public class Solution
    {
        public ListNode ReverseList(ListNode head)
        {
            ListNode prev = null;
            ListNode current = head;

            while (current != null)
            {
                ListNode nextTemp = current.next;
                current.next = prev;
                prev = current;
                current = nextTemp;
            }

            return prev;
        }
    }

    class Program
    {
        static void PrintList(ListNode head)
        {
            while (head != null)
            {
                Console.Write(head.val + " ");
                head = head.next;
            }
            Console.WriteLine();
        }

        static void Main(string[] args)
        {
            // Create linked list: 1 → 2 → 3 → 4 → null
            ListNode head = new ListNode(1, new ListNode(2, new ListNode(3, new ListNode(4))));

            Console.WriteLine("Original list:");
            PrintList(head);

            Solution sol = new Solution();
            ListNode reversedHead = sol.ReverseList(head);

            Console.WriteLine("Reversed list:");
            PrintList(reversedHead);
        }
    }

}
