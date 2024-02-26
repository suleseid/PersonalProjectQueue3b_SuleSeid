using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace PersonalProjectQueue3b_SuleSeid
{
    // Node class representing each element in the stack
    public class QueueNode<T>
    {
        public int Data { get; set; }// Value of the node
        public QueueNode<T> Next { get; set; }// Reference to the next node in the stack

        // Constructor to create a new node with a value
        public QueueNode(int data)
        {
            Data = data;
            Next = null;
        }
    }
    // Custom stack class implemented using a linked list
    public class CustomStack
    {
        private QueueNode<int> top; // Top element of the stack
        // We have to add an element on the top of the stack
        public void Push(int data) 
        {
            QueueNode<int> newNode = new QueueNode<int>(data);
            newNode.Next = top;
            top = newNode;
        }
        // Remove and return the top element of the stack
        public int Pop()
        {
            if (top == null)
                throw new InvalidOperationException("Stack is empty");

            int data = top.Data;
            top = top.Next;
            return data;
        }
        // Get the value of the top element without removing it
        public int Peek()
        {
            if (top == null)
                throw new InvalidOperationException("Stack is empty");

            return top.Data;
        }
        // Lets Check if the stack is empty
        public bool Empty()
        {
            return top == null;
        }
        // Search for an element and return if it exists in the stack.
        public int Search(int data)
        {
            int index = 1;
            QueueNode<int> current = top;
            while (current != null)
            {
                if (current.Data == data)
                    return index;
                current = current.Next;
                index++;
            }
            return -1; // Not found
        }
    }

    // Custom queue class implemented using two custom stacks
    public class QueueStacks<T>
    {
        private CustomStack stack1 = new CustomStack();// Stack for enqueue operation
        private CustomStack stack2 = new CustomStack();// Stack for dequeue operation

        // Add an element to the queue
        public void Enqueue(int data)
        {
            stack1.Push(data);
        }
        // Remove and return the first added element from the queue
        public int Dequeue()
        {
            if (stack1.Empty() && stack2.Empty())
                throw new InvalidOperationException("Queue is empty");

            if (stack2.Empty())
            {
                // If stack2 is empty, pop all elements from stack1 and push them onto stack2
                while (!stack1.Empty())
                {
                    stack2.Push(stack1.Pop());
                }
            }

            return stack2.Pop();
        }

        public int Peek()
        {
            if (stack1.Empty() && stack2.Empty())
                throw new InvalidOperationException("Queue is empty");

            if (stack2.Empty())
            {
                while (!stack1.Empty())
                {
                    stack2.Push(stack1.Pop());
                }
            }

            return stack2.Peek();
        }

        public bool Empty()
        {
            return stack1.Empty() && stack2.Empty();
        }
    }

}
