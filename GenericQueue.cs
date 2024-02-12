using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericStack
{
    public class GenericQueue<T> where T : class
    {
        private T[] QueueArray;
        private int front;
        private int rear;
        private int capacity;

        public GenericQueue(int capacity = 100)
        {
            this.capacity = capacity;
            QueueArray = new T[capacity];
            front = 0;
            rear = -1;
        }
        public void Enqueue(T item = default)
        {
            if (IsFull())
            {
                throw new InvalidOperationException("Queue is full.");
            }
            if (rear == capacity - 1)
            {
                rear = -1;
            }
            QueueArray[++rear] = item;
        }
        public T Dequeue()
        {
            if (IsEmpty())
            {
                throw new InvalidOperationException("Queue is empty");
            }
            T temp = QueueArray[front++];
            if (front == capacity)
            {
                front = 0;
            }
            return temp;
        }
        public bool IsEmpty()
        {
            return rear + 1 == front || (front + capacity - 1 == rear);
        }
        public bool IsFull()
        {
            return (rear + 2 == front) || (front + capacity - 2 == rear);
        }
    }
}
