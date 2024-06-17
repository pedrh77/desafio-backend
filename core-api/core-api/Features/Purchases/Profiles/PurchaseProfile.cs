using AutoMapper;
using core_api.Features.Purchases.DTO.Request;
using core_api.Features.Purchases.Models;

namespace core_api.Features.Purchases.Profiles
{
    public class PurchaseProfile : Profile
    {
        public PurchaseProfile()
        {
            CreateMap<CreditCardRequest, CreditCard>();
            CreateMap<TransactionRequest, Transaction>();
        }

    }
}
