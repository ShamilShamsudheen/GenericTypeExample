using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericStack
{
    public class GenericStack<T> where T : struct
    {
        private T[] stackArray;
        private int top;

        public GenericStack()
        {
            stackArray = new T[100];
            top = -1;
        }
        public void Push(T item = default)
        {
            if (!typeof(T).IsValueType)
            {
                throw new InvalidOperationException("Only vaue types are allowed.");
            }
            if (top == stackArray.Length - 1)
            {
                throw new StackOverflowException("Stack overflow.");
            }
            stackArray[++top] = item;
        }
        public T Pop()
        {
            if (top == -1)
            {
                throw new InvalidOperationException("Stack is emplty.");
            }
            return stackArray[top--];
        }
        public T Peek()
        {
            if (top == -1)
            {
                throw new InvalidOperationException("Stack is empty");
            }
            return stackArray[top];
        }
        public bool IsEmpty()
        {
            return top == -1;
        }
    }
}
