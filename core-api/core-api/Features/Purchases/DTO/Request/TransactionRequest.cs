namespace core_api.Features.Purchases.DTO.Request
{
    public class TransactionRequest
    {
        public string client_id { get; set; }
        public string client_name { get; set; }
        public int total_to_pay { get; set; }
        public CreditCardRequest credit_card { get; set; }
    }
}