using Microsoft.Azure.Cosmos;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace AzureCosmosDB
{
    class Program
    {
        
        private static readonly string _connection_string = "AccountEndpoint=https://atincosmosjune21.documents.azure.com:443/;AccountKey=wEkLvnwbw3QowkTwd18xnXAtm2kXecEQCpbTW1XYFWN1V3n5hOGlOplX93oab9hYS01wuwEu2n2GYEZtfEO8gg==;";
        private static readonly string _database_name = "appdb";
        private static readonly string _container_name = "course";
        
        static void Main(string[] args)
        {
            CosmosClient _cosmosclient = new CosmosClient(_connection_string, new CosmosClientOptions());

            Container _container = _cosmosclient.GetContainer(_database_name, _container_name);


            Course _course = new Course() { id = "6",courseid="Course0010", coursename = "AZ-204 Developing Azure solutions", rating = 4.5m };

            _container.CreateItemAsync(_course, null,new ItemRequestOptions { PreTriggers = new List<string> { "AddTimestamp" } }).GetAwaiter().GetResult();

            Console.WriteLine("Item created");
            Console.ReadKey();
        }
    }
}
