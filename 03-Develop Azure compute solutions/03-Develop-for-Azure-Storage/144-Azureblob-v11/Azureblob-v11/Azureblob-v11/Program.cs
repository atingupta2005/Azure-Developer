using Microsoft.Azure.Storage;
using Microsoft.Azure.Storage.Auth;
using Microsoft.Azure.Storage.Blob;
using System;

namespace Azureblob_v11
{
    class Program
    {
        private static string _account_name = "appstore100011";
        private static string _account_key = "/4X2MRoELqbi7vSjRouzu6rvA/kvmWMMiwxkgolLZGKuyZbTYYB3Mh/8RMWF7THwNw3sMvJtexEr6DwLn81wHQ==";
        private static string _container_name = "data";
        private static string _blob_name = "Courses.json";
        static void Main(string[] args)
        {

            StorageCredentials _credentials = new StorageCredentials(_account_name, _account_key);
            CloudStorageAccount _storageAccount = new CloudStorageAccount(_credentials, useHttps: true);

            CloudBlobClient _blobClient = _storageAccount.CreateCloudBlobClient();

            CloudBlobContainer _blobContainer = _blobClient.GetContainerReference(_container_name);

            CloudBlockBlob _blob = _blobContainer.GetBlockBlobReference(_blob_name);

            string _blob_content=_blob.DownloadText();

            Console.WriteLine(_blob_content);
            Console.ReadKey();
        }
    }
}
