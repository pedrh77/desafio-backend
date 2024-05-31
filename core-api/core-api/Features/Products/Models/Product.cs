namespace core_api.Features.Products.Models
{
    public class Product
    {
        public int id { get; set; }
        public string title { get; set; }
        public int price { get; set; }
        public string zipcode { get; set; }
        public string seller { get; set; }
        public string thumbnailHd { get; set; }
        public string date { get; set; }
    }
}
