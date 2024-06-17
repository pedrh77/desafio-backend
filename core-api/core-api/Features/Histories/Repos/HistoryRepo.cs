using core_api.Features.Histories.Contracts;
using core_api.Features.Purchases.Models;
using core_api.Infra.Context;
using Microsoft.EntityFrameworkCore;

namespace core_api.Features.Histories.Repos;

public class HistoryRepo(DataContext context) : IHistoryRepo
{

    private readonly DbSet<RelationalTransactionCreditCard> DataSetRelational = context.RelationalTransactionCreditCards;
    private readonly DbSet<Transaction> DataSetTransaction = context.Transactions;


    public async Task<IList<RelationalTransactionCreditCard>> GetHitoryAsync()
    {
        return await DataSetRelational.Include(r => r.Transation)
                                       .Include(r => r.CreditCard)
                                       .ToListAsync();
    }

    public async Task<IList<RelationalTransactionCreditCard>> GetHitoryByClientIdAsync(string clientId)
    {
        return await DataSetRelational.Include(r => r.Transation)
                                       .Include(r => r.CreditCard)
                                       .Where(x => x.Transation.client_id == clientId)
                                       .ToListAsync();
    }
}