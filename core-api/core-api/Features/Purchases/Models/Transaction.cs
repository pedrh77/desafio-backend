namespace core_api.Features.Purchases.Models
{
    public class Transaction
    {
        public int Id { get; set; }
        public string client_id { get; set; }
        public string client_name { get; set; }
        public int total_to_pay { get; set; }
        public CreditCard credit_card { get; set; }
    }
}
