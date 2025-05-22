using System;

class Program
{
    public class ListNode
    {
        public int val;
        public ListNode next;

        public ListNode(int value)
        {
            val = value;
            next = null;
        }
    }

    public static ListNode SwapPairsHead(ListNode head)
    {
        if (head == null || head.next == null)
            return head;

        ListNode second = head.next;
        head.next = SwapPairsHead(second.next); // рекурсія перед обробкою поточної пари
        second.next = head;

        return second;
    }
    public static ListNode SwapPairsTail(ListNode head)
    {
        return SwapTail(null, head);
    }

    private static ListNode SwapTail(ListNode prev, ListNode current)
    {
        if (current == null || current.next == null)
            return prev == null ? current : prev.next;

        ListNode next = current.next;
        ListNode nextPair = next.next;

        // міняємо місцями current і next
        next.next = current;
        current.next = nextPair;

        if (prev != null)
            prev.next = next;

        // Рекурсія як останній виклик
        SwapTail(current, nextPair);

        return prev == null ? next : null; // тільки перший виклик повертає нову голову
    }

    static void PrintList(ListNode head)
    {
        while (head != null)
        {
            Console.Write(head.val + " ");
            head = head.next;
        }
        Console.WriteLine();
    }

    static void Main()
    {
        // Створюємо список: [1,2,3,4]
        ListNode head = new ListNode(1);
        head.next = new ListNode(2);
        head.next.next = new ListNode(3);
        head.next.next.next = new ListNode(4);

        // Head recursion
        var result1 = SwapPairsHead(head);
        PrintList(result1); // Виведе: 2 1 4 3

        // Щоб протестувати хвостову версію, створюємо список заново
        ListNode head2 = new ListNode(1);
        head2.next = new ListNode(2);
        head2.next.next = new ListNode(3);
        head2.next.next.next = new ListNode(4);

        // Tail recursion
        var result2 = SwapPairsTail(head2);
        PrintList(result2); // Виведе: 2 1 4 3
    }

}