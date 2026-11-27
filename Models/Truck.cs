namespace LogiRoute.Models
{
    public class Truck
    {
        public int TruckID { get; set; }
        public string TruckName { get; set; } = string.Empty;
        public int MaxWeight { get; set; }
        public int MaxVolume { get; set; }
    }

}
