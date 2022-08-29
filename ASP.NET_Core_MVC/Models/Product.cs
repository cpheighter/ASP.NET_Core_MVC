namespace ASP.NET_Core_MVC.Models
{
    public class Product
    {
        public int ProductId { get; set; }  
        public string Name { get; set; }
        public double Price { get; set; }
        public int CategoryID { get; set; }
        public int OnSale { get; set; }
        public int StockLevel { get; set; }
        public IEnumerable<Category> Categories { get; set; }
    }
}
