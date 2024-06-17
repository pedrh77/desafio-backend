namespace core_api.Features.Histories.DTO.Response
{
    public class HistoryReponse
    {
        public string client_id { get; set; }
        public string purchase_id { get; set; }
        public int value { get; set; }
        public string date { get; set; }
        public string card_number { get; set; }
    }
}
