using AutoMapper;
using core_api.Features.Histories.DTO.Response;
using core_api.Features.Purchases.Models;

namespace core_api.Features.Histories.Profiles;

public class HistoryProfile : Profile
{
    public HistoryProfile()
    {
        CreateMap<RelationalTransactionCreditCard, HistoryReponse>()
            .ForMember(d => d.client_id, opt => opt.MapFrom(src => src.Transation.client_id))
            .ForMember(d => d.purchase_id, opt => opt.MapFrom(src => src.Id.ToString()))
            .ForMember(d => d.value, opt => opt.MapFrom(src => src.CreditCard.value))
            .ForMember(d => d.date, opt => opt.MapFrom(src => src.CreatedIn))
            .ForMember(d => d.card_number, opt => opt.MapFrom(src => censoredCreditCard(src.CreditCard.card_number)));
    }

    private string censoredCreditCard(string CreditCard)
    {
        return "**** **** **** " + CreditCard.Substring(12);
    }
}