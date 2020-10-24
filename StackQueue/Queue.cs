using System;
using System.Collections.Generic;
using System.Text;

namespace StackQueue
{
    public class Queue
    {
        Node head;
        /// Enqueue method adds an element to the queue 
        public void Enqueue(int item)
        {
            Node newNode = new Node(item);
            if (this.head == null)
            {
                this.head = newNode;
            }
            else
            {
                Node temp = this.head;
                while (temp.next != null)
                {
                    temp = temp.next;
                }
                temp.next = newNode;
            }
            Console.WriteLine("inserted into list " + newNode.data);
        }
        /// It deletes the last element added 
        public void Dequeue()
        {  
            if (this.head == null)
            {
                Console.WriteLine("The Queue is empty");
                return;
            }
            Node temp = this.head;
            this.head = this.head.next;

            Console.WriteLine("\nItem deleted is {0}", temp.data);
        }
        /// Displays the queue by traversing through it
        public void DisplayQueue()
        {
            Node temp = this.head;
            if (temp == null)
            {
                Console.WriteLine("queue is empty");
                return;
            }
            else
            {
                while (temp != null)
                {
                    Console.Write(" " + temp.data);
                    temp = temp.next;
                }
            }
        }
    }
}
