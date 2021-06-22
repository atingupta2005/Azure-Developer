using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.WindowsAzure;
using Microsoft.WindowsAzure.Storage;

using Microsoft.WindowsAzure.Storage.Auth;

using Microsoft.WindowsAzure.Storage.Table;

namespace Table
{
    class Program
    {
        static void Main(string[] args)
        {

            CloudStorageAccount storageAccount = CloudStorageAccount.Parse("DefaultEndpointsProtocol=https;AccountName=demotableapi;AccountKey=prJ3A0E36PeF1TP81dNYPZQPlpnn3gMRTjMhQh1HPkmM9y1mecZPlE8JvyQ96CxZNjdko3A9k4YPrd1R1mSszg==;TableEndpoint=https://demotableapi.table.cosmos.azure.com:443/;");
            CloudTableClient tableClient = storageAccount.CreateCloudTableClient();
            CloudTable table = tableClient.GetTableReference("product");            
            TableQuery<ProductEntity> query = new TableQuery<ProductEntity>().Where(TableQuery.GenerateFilterCondition("PartitionKey", QueryComparisons.Equal, "InStock"));
            // Access the fields for each product.
            foreach (ProductEntity entity in table.ExecuteQuery(query))
            {
                Console.WriteLine("{0}, {1}\t{2}\t{3}", entity.PartitionKey, entity.RowKey,
                    entity.Location, entity.ProductName);
            }
        }
    }
}
