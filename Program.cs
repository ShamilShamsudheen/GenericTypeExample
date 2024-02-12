using GenericStack;
using System;
class Program
{
    
    static void Main(string[] args)
    {
        
        Console.WriteLine("Choose an option:");
        Console.WriteLine("1. Stack");
        Console.WriteLine("2. Queue");

        string choice = Console.ReadLine();

        switch (choice)
        {
            case "1":
                TestStackOperations();
                break;
            case "2":
                TestQueueOperations();
                break;
            default:
                Console.WriteLine("Invalid choice.");
                break;
        }
    }
    static void TestStackOperations()
    {
        var stack = new GenericStack<int>();
        bool checking = true;
        while (checking)
        {

        
        Console.WriteLine("Choose a stack operation:");
        Console.WriteLine("1. Push");
        Console.WriteLine("2. Pop");
        Console.WriteLine("3. Peek");
        Console.WriteLine("4. IsEmpty");
        Console.WriteLine("5. Exit");

            string operation = Console.ReadLine();

        switch (operation)
        {
            case "1":
                Console.WriteLine("Enter the value to push:");
                int value;
                if (int.TryParse(Console.ReadLine(), out value))
                {
                    stack.Push(value);
                    Console.WriteLine("Value pushed onto the stack.");
                }
                else
                {
                    Console.WriteLine("Invalid input.");
                }
                break;
            case "2":
                try
                {
                    int poppedValue = stack.Pop();
                    Console.WriteLine("Popped value: " + poppedValue);
                }
                catch (InvalidOperationException ex)
                {
                    Console.WriteLine(ex.Message);
                }
                break;
            case "3":
                try
                {
                    int peekedValue = stack.Peek();
                    Console.WriteLine("Top element: " + peekedValue);
                }
                catch (InvalidOperationException ex)
                {
                    Console.WriteLine(ex.Message);
                }
                break;
            case "4":
                Console.WriteLine("Stack is empty? " + stack.IsEmpty());
                break;
            case "5":
                checking = false;
                break;
            default:
                Console.WriteLine("Invalid operation.");
                
                break;
        }
        }
    }
    static void TestQueueOperations()
    {
        var queue = new GenericQueue<ChatMessage>();
        bool checking = true;
        while (checking) { }
        Console.WriteLine("Choose a queue operation:");
        Console.WriteLine("1. Enqueue");
        Console.WriteLine("2. Dequeue");
        Console.WriteLine("3. IsEmpty");
        Console.WriteLine("4. IsFull");
        Console.WriteLine("5. Exit");

        string operation = Console.ReadLine();

        switch (operation)
        {
            case "1":
                Console.WriteLine("Enter message details:");
                Console.WriteLine("MessageId:");
                int messageId = int.Parse(Console.ReadLine());
                Console.WriteLine("Content:");
                string content = Console.ReadLine();
                DateTime timeStamp = DateTime.Now;
                Console.WriteLine("SourceId:");
                int sourceId = int.Parse(Console.ReadLine());
                queue.Enqueue(new ChatMessage(messageId, content, timeStamp, sourceId));
                Console.WriteLine("Message enqueued.");
                break;
            case "2":
                try
                {
                    ChatMessage dequeuedMessage = queue.Dequeue();
                    Console.WriteLine("Dequeued message: " + dequeuedMessage);
                }
                catch (InvalidOperationException ex)
                {
                    Console.WriteLine(ex.Message);
                }
                break;
            case "3":
                Console.WriteLine("Queue is empty? " + queue.IsEmpty());
                break;
            case "4":
                Console.WriteLine("Queue is Full? "+ queue.IsFull());
                break;
            case "5":
                checking = false;
                break;
            default:
                Console.WriteLine("Invalid operation.");
                break;
        }

    }


}


