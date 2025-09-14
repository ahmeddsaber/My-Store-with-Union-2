namespace MyStore.Models
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string? Description { get; set; }
        public int UnitInStock { get; set; }
        public double UnitPrice { get; set; }
        public int CatagoryId { get; set; }
        public Catagory Catagory { get; set; }
    }
}
