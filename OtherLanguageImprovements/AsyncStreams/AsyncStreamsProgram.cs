using System;
using System.Threading;

namespace AsyncStreams
{
    public class AsyncStreamsProgram
    {
        static int ThreadId => Thread.CurrentThread.ManagedThreadId;

        public static async System.Threading.Tasks.Task StartAsync(string[] args)
        {
            var orderFactory = new OrderFactory();

            Console.WriteLine($"[{ThreadId}]Enumerating Orders...");

            await foreach (var order in orderFactory.MakeOrdersAsync(5))
            {
                Console.WriteLine($"[{ThreadId}]Recieved order {order.Id}.");
            }
            Console.WriteLine($"[{ThreadId}]All orders created!");
        }
    }
}
