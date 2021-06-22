using Microsoft.Azure.Cosmos;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace CosmosDB
{
    class Program
    {
        private static readonly string _connection_string = "AccountEndpoint=https://appaccount100.documents.azure.com:443/;AccountKey=VvzlQECZtYzfEFvvEnHcqQkrcE39FgxXwM5TuGfxFx2VCxgovcPZwBVSxsgyJbsTaEVVzQvNWgq9wPJszzZyVg==;";
        private static readonly string _database_name = "appdb";
        private static readonly string _container_name = "course";
        
        static void Main(string[] args)
        {

            CosmosClient _client = new CosmosClient(_connection_string,new CosmosClientOptions());

            Container _container=_client.GetContainer(_database_name, _container_name);

            Course _course = new Course()
            { id = "6", courseid = "Course0008", coursename = "SC-900 Azure Security Fundamentals", rating = 4.4m };

            _container.CreateItemAsync<Course>(_course, null, new ItemRequestOptions { PreTriggers = new List<string> { "Addtimestamp" } }).GetAwaiter().GetResult();

            Console.WriteLine("Item is created");
          
            Console.ReadKey();
        }
    }
}
