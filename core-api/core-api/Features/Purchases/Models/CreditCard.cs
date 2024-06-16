namespace core_api.Features.Purchases.Models
{
    public class CreditCard
    {
        public int Id { get; set; }
        public string card_number { get; set; }
        public string card_holder_name { get; set; }
        public int value { get; set; }
        public int cvv { get; set; }
        public string exp_date { get; set; }
    }
}