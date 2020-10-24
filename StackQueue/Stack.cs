using System;
using System.Collections.Generic;
using System.Text;

namespace StackQueue
{
    public class Stack
    {
        public Node top;
        /// Method to push elements to the stack
        /// the last entered element becomes the top of the stack
        public void Push(int value) {
            Node newNode = new Node(value);
            if (this.top == null)
            {
                newNode.next = null;
            }
            else {
                newNode.next = this.top;
            }
            this.top = newNode;
            Console.WriteLine(value+" is added to the stack");
        }
        public void DisplayStack() {
            Node temp = this.top;
            if (temp == null)
            {
                Console.WriteLine("Stack is empty");
            }
            else {
                while (temp!=null)
                {
                    Console.Write("\t" + temp.data);
                    temp = temp.next;
                }
            }
        }
    }
}
