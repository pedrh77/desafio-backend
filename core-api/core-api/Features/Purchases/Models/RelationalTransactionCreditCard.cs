namespace core_api.Features.Purchases.Models;

public class RelationalTransactionCreditCard
{
    public Guid Id { get; set; } = Guid.NewGuid();
    public int TransationId { get; set; }
    public Transaction Transation { get; set; }
    public int CreditCardId { get; set; }
    public CreditCard CreditCard { get; set; }
    public string CreatedIn { get; set; } = DateTime.UtcNow.ToString("dd/MM/yyyy");
}