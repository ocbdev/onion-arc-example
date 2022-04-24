using Microsoft.AspNetCore.Mvc;
using OnionExample.Application.Dto;
using OnionExample.Application.Interfaces.Repository;

namespace OnionExample.WebAPI.Controllers;

[Route("api/[controller]")]
[ApiController]
public class ProductController : ControllerBase
{
    private readonly IProductRepository _productRepository;

    public ProductController(IProductRepository productRepository)
    {
        _productRepository = productRepository;
    }

    [HttpGet]
    public async Task<IActionResult> Get()
    {
        var allList = await _productRepository.GetAllAsync();
        var result = allList.Select(i => new ProductViewDto()
        {
            Id = i.Id,
            ProductName = i.ProductName
        });
        return Ok(result);
    }
}