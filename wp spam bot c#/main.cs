using System;
using System.Threading;

class Program
{
    static void Main()
    {
        SpamMessages("Hello, How Are You", 10);
    }

    static void SpamMessages(string message, int numberOfMessages)
    {
        for (int i = 0; i < numberOfMessages; i++)
        {
            Console.Write(message);
            Console.WriteLine(); // Simulate pressing Enter

            // Wait for 1 second
            Thread.Sleep(1000);
        }
    }
}
