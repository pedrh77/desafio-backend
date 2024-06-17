using core_api.Features.Purchases.DTO.Request;

namespace core_api.Features.Purchases.Contracts
{
    public interface IPurchaseServices
    {
        Task NovaCompra(TransactionRequest request);
    }
}
