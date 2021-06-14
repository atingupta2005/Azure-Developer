using Azure.Messaging.ServiceBus;
using System;
using System.Threading;

namespace ServiceBus_Queue_Receive
{
    class Program
    {
        private static string connection_string = "Endpoint=sb://appnamespace10001.servicebus.windows.net/;SharedAccessKeyName=Listen;SharedAccessKey=mNV94Pg3soW+lbpZQsbq4Fbwt5wIjYa2bZcyEvWYuOg=;EntityPath=appqueue";
        private static string queue_name = "appqueue";
        static void Main(string[] args)
        {
            ServiceBusClient _client = new ServiceBusClient(connection_string);

            ServiceBusReceiver _receiver = _client.CreateReceiver(queue_name,new ServiceBusReceiverOptions() {ReceiveMode= ServiceBusReceiveMode.PeekLock });

            ServiceBusReceivedMessage _message= _receiver.ReceiveMessageAsync().GetAwaiter().GetResult();

            Console.WriteLine(_message.Body);
            Console.WriteLine($"The Sequence number is {_message.SequenceNumber}");

            
            _receiver.CompleteMessageAsync(_message);

        }
    }
}
