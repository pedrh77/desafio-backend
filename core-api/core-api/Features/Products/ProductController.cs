using core_api.Features.Products.Contracts;
using core_api.Features.Products.DTO.Request;
using core_api.Features.Products.DTO.Response;
using core_api.Features.Products.Services;
using Microsoft.AspNetCore.Mvc;

namespace core_api.Features.Products;

[ApiController]
public class ProductController(IProductService _service) : ControllerBase
{
    [HttpPost("/starstore/product")]
    public async Task<IActionResult> NovoProdutoAsync([FromBody] NovoProdutoRequest request)
    {
        

        await _service.NovoProdutoAsync(request);
        return Ok();
    }

    [HttpGet("/starstore/products")]
    public async Task<IList<ProductsResponse>> BuscaProdutosAsync()
    {
        return await _service.BuscaProdutoAsync();
    }


}
