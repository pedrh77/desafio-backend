using core_api.Features.Histories.Contracts;
using core_api.Features.Histories.DTO.Response;
using Microsoft.AspNetCore.Mvc;

namespace core_api.Features.Histories;

[ApiController]
public class HistoryController(IHistoryServices _service) : ControllerBase
{
    [HttpGet("/starstore/history")]
    public async Task<IList<HistoryReponse>> GetHistoriesAsync()
    {
       return await _service.GetTransactionsAsync();
    }
    [HttpGet("/starstore/history/{clientId}")]
    public async Task<IList<HistoryReponse>> GetHistoriesAsync(string clientId)
    {
        return await _service.GetTransactionsByClientIdAsync(clientId);
    }
}