namespace LogiRoute.Models
{
    public class Product
    {
        public int ProductID { get; set; }
        public string ProductName { get; set; } = string.Empty;
        public decimal Value { get; set; }
        public int Weight { get; set; }
        public int Volume { get; set; }
        public bool IsMandatory { get; set; }
    }

}

