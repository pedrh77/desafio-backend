using core_api.Features.Purchases.Models;

namespace core_api.Features.Histories.Contracts
{
    public interface IHistoryRepo
    {
        Task<IList<RelationalTransactionCreditCard>> GetHitoryAsync();
        Task<IList<RelationalTransactionCreditCard>> GetHitoryByClientIdAsync(string clientId);
    }
}
