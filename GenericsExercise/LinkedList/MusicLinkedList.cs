using System;
using System.Collections.Generic;
using System.Text;

namespace LinkedList
{
    public class MusicLinkedList<T>
    {
        private class ListNode
        {
            public int Value { get; set; }
            public ListNode NextNode { get; set; }
            public ListNode PreviousNode { get; set; }
            public ListNode(int value)
            {
                this.Value = value;
            }
        }
        private ListNode head;
        private ListNode tail;
        public int Count { get; set; }

        public void AddFirst(int item)
        {
            if (this.Count == 0)
            {
                this.head = this.tail = new ListNode(item);
            }
            else
            {
                var newHead = new ListNode(item);
                newHead.NextNode = this.head;
                this.head.PreviousNode = newHead;
                this.head = newHead;
            }

            this.Count++;
        }
        public void AddLast(int item)
        {
            if (this.Count == 0)
            {
                this.tail = this.head = new ListNode(item);
            }
            else
            {
                var newTail = new ListNode(item);
                newTail.PreviousNode = this.tail;
                this.tail.NextNode = newTail;
                this.tail = newTail;
            }

            this.Count++;
        }
        public int RemoveFirst()
        {
            if (this.Count == 0)
            {
                throw new InvalidCastException("The list is empty");
            }
            var firstElement = this.head.Value;
            this.head = this.head.NextNode;
            if (this.head != null)
            {
                this.head.PreviousNode = null;
            }
            else
            {
                this.tail = null;
            }
            this.Count--;
            return firstElement;
        }
        public int RemoveLast()
        {
            if (this.Count == 0)
            {
                throw new InvalidCastException("The list is empty");
            }
            var lastElement = this.tail.Value;
            this.tail = this.tail.PreviousNode;
            if (this.tail != null)
            {
                this.tail.PreviousNode = null;
            }
            else
            {
                this.head = null;
            }
            this.Count--;
            return lastElement;
        }

        public void ForEachFromHead(Action<NodeMusic<T>> action)
        {
            var currentNode = this.head;

            while (currentNode != null)
            {
                action(currentNode.Value);
                currentNode = currentNode.NextNode;
            }
        }
        public void ForEachFromTail(Action<int> action)
        {
            var currentNode = this.tail;

            while (currentNode != null)
            {
                action(currentNode.Value);
                currentNode = currentNode.PreviousNode;
            }
        }

        public int[] ToArray()
        {
            int[] array = new int[this.Count];
            int counter = 0;
            var currentNode = this.head;
            while (currentNode != null)
            {
                array[counter] = currentNode.Value;
                currentNode = currentNode.NextNode;
                counter++;
            }
            return array;
        }

    }
}
