namespace core_api.Features.Products.DTO.Request;

public class NovoProdutoRequest
{
    public string title { get; set; }
    public int price { get; set; }
    public string zipcode { get; set; }
    public string seller { get; set; }
    public string thumbnailHd { get; set; }
    public string date { get; set; }
}
