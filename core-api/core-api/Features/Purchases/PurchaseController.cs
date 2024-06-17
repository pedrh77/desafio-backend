using core_api.Features.Products.DTO.Request;
using core_api.Features.Purchases.Contracts;
using core_api.Features.Purchases.DTO.Request;
using Microsoft.AspNetCore.Mvc;

namespace core_api.Features.Purchases
{
    public class PurchaseController(IPurchaseServices _service) : ControllerBase
    {

        [HttpPost("/starstore/buy")]
        public async Task<IActionResult> NovaCompra([FromBody] TransactionRequest request)
        {
            await _service.NovaCompra(request);
            return Ok();
        }

    }
}
