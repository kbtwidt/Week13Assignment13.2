namespace Week13Assignment13._2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Problem: Given the head of a linked list, remove the nth node from the end of the list and return its head.
             */
            Console.WriteLine("Part 1");

            LinkedList list = new LinkedList();
            list.Add(1);
            list.Add(2);
            list.Add(3);
            list.Add(4);
            list.Add(5);

            Console.WriteLine("List: ");
            list.Display();

            int n = 2;

            Solution solution = new Solution();
            ListNode result = solution.RemoveNthFromEnd(list.head, n);

            LinkedList resultList = new LinkedList();
            resultList.head = result;

            Console.WriteLine($"List with nth node from end removed: (n={n})");
            resultList.Display();
        }
    }

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

    public class LinkedList
    {
        public ListNode head;

        public void Add(int value)
        {
            ListNode newNode = new ListNode(value);

            if (head == null)
            {
                head = newNode;
                return;
            }

            ListNode current = head;

            while (current.next != null)
                current = current.next;

            current.next = newNode;
        }

        public void Display()
        {
            ListNode current = head;

            while (current != null)
            {
                Console.Write(current.val);

                if (current.next != null)
                    Console.Write(" -> ");

                current = current.next;
            }

            Console.WriteLine();
        }
    }


    public class Solution
    {
        public ListNode RemoveNthFromEnd(ListNode head, int n)
        {
            int size = 0;
            ListNode curr = head;

            while (curr != null)
            {
                size++;
                curr = curr.next;
            }

            if (n == size)
            {
                return head.next;
            }

            curr = head;

            for (int i = 0; i < size - n - 1; i++)
            {
                curr = curr.next;
            }

            curr.next = curr.next.next;

            return head;
        }
    }

}
