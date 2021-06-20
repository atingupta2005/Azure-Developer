using Microsoft.Practices.EnterpriseLibrary.TransientFaultHandling;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace TransientDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                
                var retryStrategy = new Incremental(2, TimeSpan.FromSeconds(2), TimeSpan.FromSeconds(2));

                var retryPolicy = new RetryPolicy<CustomTransientErrorDetectionStrategy>(retryStrategy);
                retryPolicy.ExecuteAction(NavigateTo);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

        static private void NavigateTo()
        {
            Console.WriteLine(DateTime.Now);

            WebClient wc = new WebClient();
            wc.DownloadString("c:\\test.txt");
        }

        internal class CustomTransientErrorDetectionStrategy : ITransientErrorDetectionStrategy
        {
            public bool IsTransient(Exception ex)
            {
                if (ex is WebException)
                    return true;
                return false;
            }
        }
    }
}
