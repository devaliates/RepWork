using Microsoft.AspNetCore.Mvc;

using RepWork.ServiceLayerExample.Abstract;
using RepWork.ServiceLayerExample.Dtos;

namespace RepWork.WebApiExample.Controllers;

[Route("api/[controller]")]
[ApiController]
public class ProductsController : ControllerBase
{
    private readonly IProductService productService;

    public ProductsController(IProductService productService)
    {
        this.productService = productService;
    }

    // POST api/<ProductsController>
    [HttpPost]
    public async Task Post([FromBody] AddProductDto value)
    {
        await productService.Add(value);
    }
}