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
        /// This method gives the top element of the stack
        public void Peek() {
            if (this.top == null)
            {
                Console.WriteLine("Stack is empty");
            }
            else {
                Console.WriteLine(this.top.data+" is the top element of the stack");
            }
        }
        //Pop method deletes the top data 
        public void Pop() {
            if (this.top == null)
            {
                Console.WriteLine("No further popping");
            }
            else {
                Console.WriteLine(this.top.data+" has been popped");
                this.top = this.top.next;
            }
        }
        //Method to accommodate simultaneous popping and peeking till the stack becomes empty
        public void PeekAndPop() {
            while (this.top != null) {
                Peek();
                Pop();
            }
        }
        /// Method to display a stack by traversing through it
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
