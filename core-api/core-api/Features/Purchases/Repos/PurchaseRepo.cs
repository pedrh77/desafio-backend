using core_api.Features.Purchases.Contracts;
using core_api.Features.Purchases.Models;
using core_api.Infra.Context;
using Microsoft.EntityFrameworkCore;

namespace core_api.Features.Purchases.Repos
{
    public class PurchaseRepo(DataContext context) : IPurchaseRepo
    {

        private readonly DbSet<Transaction> DataSetTransactions = context.Transactions;
        private readonly DbSet<RelationalTransactionCreditCard> DataSetRelationals = context.RelationalTransactionCreditCards;
        private readonly DbSet<CreditCard> DataSetCreditCards = context.CreditCards;


        public async Task<Transaction> AddTransactionsAsync(Transaction transaction)
        {
            await DataSetTransactions.AddAsync(transaction);
            await Commit();
            return transaction;
        }
        public async Task<CreditCard> AddCreditCardsAsync(CreditCard creditcard)
        {
            await DataSetCreditCards.AddAsync(creditcard);
            await Commit();
            return creditcard;
        }

        public async Task<RelationalTransactionCreditCard> AddRelationalsAsync(RelationalTransactionCreditCard relational)
        {
            await DataSetRelationals.AddAsync(relational);
            await Commit();
            return relational;
        }

        public async Task Commit()
                => await context.SaveChangesAsync();

    }
}
