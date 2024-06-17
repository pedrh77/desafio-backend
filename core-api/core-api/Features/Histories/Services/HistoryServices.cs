using AutoMapper;
using core_api.Features.Histories.Contracts;
using core_api.Features.Histories.DTO.Response;

namespace core_api.Features.Histories.Services;
public class HistoryServices(IHistoryRepo _repo, IMapper _mapper) : IHistoryServices
{
    public async Task<IList<HistoryReponse>> GetTransactionsAsync()
    {
        return (_mapper.Map<IList<HistoryReponse>>(await _repo.GetHitoryAsync()));
    }

    public async Task<IList<HistoryReponse>> GetTransactionsByClientIdAsync(string ClientId)
    {
        return (_mapper.Map<IList<HistoryReponse>>(await _repo.GetHitoryByClientIdAsync(ClientId)));
    }
}