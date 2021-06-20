using Microsoft.WindowsAzure.Storage.Table;



namespace Table
{
    public class ProductEntity:TableEntity
    {
        public ProductEntity() { }
        public string ProductId { get; set; }
        public string Stock { get; set; }
        public string ProductName { get; set; }
        public string Location { get; set; }
        public string Quantity { get; set; }

    }
}
