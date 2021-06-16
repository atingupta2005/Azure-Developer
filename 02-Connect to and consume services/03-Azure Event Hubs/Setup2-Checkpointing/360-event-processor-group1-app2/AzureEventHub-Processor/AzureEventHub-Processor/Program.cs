using Azure.Messaging.EventHubs;
using Azure.Messaging.EventHubs.Consumer;
using Azure.Messaging.EventHubs.Processor;
using Azure.Storage.Blobs;
using System;
using System.Text;
using System.Threading.Tasks;

namespace AzureEventHub_Processor
{
    class Program
    {
        private static string connection_string = "Endpoint=sb://appnamespace1000atin.servicebus.windows.net/;SharedAccessKeyName=all;SharedAccessKey=6lhIQdDTMVWHRVqm6zMcWGIYgKie9QeZFhL0M3Iw98w=;EntityPath=apphub";
        private static string consumer_group = "group1";
        private static string storage_account_connection = "DefaultEndpointsProtocol=https;AccountName=saatin;AccountKey=x+dLw3IV8s/WgdNomADXFhS9LPphZ/8RjupB/VxvtSwTf3SQojQa1i3YQPlRzlNX6c2b4t45ZEu+Dxb3PJVlLw==;EndpointSuffix=core.windows.net";
        private static string container_name = "eventhub";
        private static long ktr = 0;
        static async Task Main(string[] args)
        {
            
            BlobContainerClient _container_client = new BlobContainerClient(storage_account_connection, container_name);

            EventProcessorClient _processor = new EventProcessorClient(_container_client, consumer_group, connection_string);

            _processor.ProcessErrorAsync += OurErrorHandler;
            _processor.ProcessEventAsync+= OurEventsHandler;

            await _processor.StartProcessingAsync();

            // Wait for 30 seconds for the events to be processed
            await Task.Delay(TimeSpan.FromSeconds(30));


            Console.ReadKey();
        }

        static async Task OurEventsHandler(ProcessEventArgs eventArgs)
        {
            ktr++;
            Console.WriteLine($"Sequence number {eventArgs.Data.SequenceNumber}");
            Console.WriteLine(Encoding.UTF8.GetString(eventArgs.Data.EventBody));
            Console.WriteLine($"ktr: {ktr}");
            await eventArgs.UpdateCheckpointAsync(eventArgs.CancellationToken);
        }

        static Task OurErrorHandler(ProcessErrorEventArgs eventArgs)
        {
            Console.WriteLine(eventArgs.Exception.Message);
            return Task.CompletedTask;
        }
    }
}
