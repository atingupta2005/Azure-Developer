# Queries

- Alert when queue is reached to max size
  - Create an alert rule in the Service Bus

- Check msg is delivered to DLQ if max del count is reached
Every message in a Service Bus queue or subscription maintains a count of how many times that message has been received. The DeliveryCount property of the message starts at zero, and then increments by one each time a receiving application receives the message.

When a message is received from a queue by an application using the peek-lock receive mode the receiving application can perform one of the following operations.



- Best Practices for different services
- Do's and Don't
- Storage Download Card. How to do compression on the cloud?
  - https://josef.codes/azure-storage-zip-multiple-files-using-azure-functions/
  - https://andrewstevens.dev/posts/stream-files-to-zip-file-in-azure-blob-storage/
  - https://arjenstolk.wordpress.com/2020/12/02/zip-azure-blob-files-directly-to-a-zip-file/
- API vs Web App storage
  - Should use Azure Front door service with firewall
- 
