using core_api.Features.Products.Contracts;
using core_api.Features.Products.DTO.Request;
using core_api.Features.Products.DTO.Response;
using Microsoft.AspNetCore.Mvc;

namespace core_api.Features.Products;

[ApiController]
[Route("/starstore/product")]
public class ProductController(IProductService _service) : ControllerBase
{
    [HttpPost]
    public async Task<IActionResult> NovoProdutoAsync([FromBody] NovoProdutoRequest request)
    {
        await _service.NovoProdutoAsync(request);
        return Ok();
    }

    [HttpGet]
    public async Task<IList<ProductsResponse>> BuscaProdutosAsync()
    {
        return await _service.BuscaProdutoAsync();
    }


}
