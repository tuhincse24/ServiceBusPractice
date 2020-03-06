using System;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.Azure.ServiceBus;

namespace ServiceBusPractice
{
    class Program
    {
        const string ServiceBusConnectionString = "<your_connection_string>";
        const string QueueName = "<your_queue_name>";
        static IQueueClient queueClient;
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
}
