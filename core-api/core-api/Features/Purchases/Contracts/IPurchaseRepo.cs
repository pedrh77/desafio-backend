using core_api.Features.Purchases.Models;

namespace core_api.Features.Purchases.Contracts
{
    public interface IPurchaseRepo
    {
        Task<Transaction> AddTransactionsAsync(Transaction transaction);
        Task<CreditCard> AddCreditCardsAsync(CreditCard creditcard);
        Task<RelationalTransactionCreditCard> AddRelationalsAsync(RelationalTransactionCreditCard relational);
        Task Commit();
    }
}
