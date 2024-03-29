using Logger.ToSeq.API.Context;
using Logger.ToSeq.API.DTOs;
using Logger.ToSeq.API.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Logger.ToSeq.API.Controllers;
[Route("api/[controller]/[action]")]
[ApiController]
public class ProductsController(AppDbContext context) : ControllerBase
{
    [HttpGet]
    public async Task<IActionResult> GetAll(CancellationToken cancellationToken)
    {
        var products = await context.Products.ToListAsync(cancellationToken);
        if (products is null)
        {
            throw new ArgumentException("Product list null");
        }
        return Ok(products);
    }

    [HttpPost]
    public async Task<IActionResult> Create(ProductDto request, CancellationToken cancellationToken = default)
    {
        var product = new Product()
        {
            Name = request.Name,
            Price = request.Price
        };

        await context.Products.AddAsync(product, cancellationToken);
        await context.SaveChangesAsync(cancellationToken);

        return NoContent();
    }

    [HttpPost]
    public async Task<IActionResult> Update(string id, ProductDto request, CancellationToken cancellationToken)
    {
        var product = await context.Products.FindAsync(id);
        if (product is null)
        {
            throw new ArgumentException("Product not found");
        }

        product!.Name = request.Name;
        product.Price = request.Price;

        await context.SaveChangesAsync(cancellationToken);

        return NoContent();
    }

    [HttpPost]
    public async Task<IActionResult> DeleteById(string id, CancellationToken cancellationToken)
    {
        var product = await context.Products.FindAsync(id);
        if (product is null)
        {
            throw new ArgumentException("Product not found");
        }

        context.Products.Remove(product!);
        await context.SaveChangesAsync(cancellationToken);

        return NoContent();
    }
}
