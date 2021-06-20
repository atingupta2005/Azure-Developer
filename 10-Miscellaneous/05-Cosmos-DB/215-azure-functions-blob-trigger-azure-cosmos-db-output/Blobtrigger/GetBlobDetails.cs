using System;
using System.IO;
using Microsoft.Azure.WebJobs;
using Microsoft.Azure.WebJobs.Host;
using Microsoft.Extensions.Logging;

namespace Blobtrigger
{
    public static class GetBlobDetails
    {
        [FunctionName("BlobDetails")]
        public static void Run([BlobTrigger("data/{name}", Connection = "storageconnection")]Stream myBlob, 
            [CosmosDB (
               databaseName:"appdb",
               collectionName:"blobs",
               ConnectionStringSetting ="CosmosDBConnection")] out dynamic document,
            string name, ILogger log)
        {
            Blob _blob = new Blob()
            {
                blobname = name,
                blobid = Guid.NewGuid().ToString(),
                blobsize = myBlob.Length
            };

            document = _blob;
        }
    }
}
