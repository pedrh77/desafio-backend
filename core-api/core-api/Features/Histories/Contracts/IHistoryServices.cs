using core_api.Features.Histories.DTO.Response;
using core_api.Features.Purchases.Models;

namespace core_api.Features.Histories.Contracts;

public interface IHistoryServices
{
    Task<IList<HistoryReponse>> GetTransactionsAsync();
    Task<IList<HistoryReponse>> GetTransactionsByClientIdAsync(string ClientId);
}