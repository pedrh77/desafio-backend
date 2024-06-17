using AutoMapper;
using core_api.Features.Purchases.Contracts;
using core_api.Features.Purchases.DTO.Request;
using core_api.Features.Purchases.Models;

namespace core_api.Features.Purchases.Services;

public class PurchaseServices(IMapper _mapper, IPurchaseRepo _repo) : IPurchaseServices
{
    public async Task NovaCompra(TransactionRequest request)
    {
        var creditCard = await _repo.AddCreditCardsAsync(_mapper.Map<CreditCard>(request.credit_card));
        var transaction = await _repo.AddTransactionsAsync(_mapper.Map<Transaction>(request));

        var relational = new RelationalTransactionCreditCard()
        {
            CreditCardId = creditCard.Id,
            TransationId = transaction.Id
        };
        await _repo.AddRelationalsAsync(relational);
    }
}
