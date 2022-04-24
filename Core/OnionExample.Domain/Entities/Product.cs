using OnionExample.Domain.Entities.Common;

namespace OnionExample.Domain.Entities;

public class Product:BaseEntity
{
    public string ProductName { get; set; }
    public decimal Price { get; set; }
    public int Quantity { get; set; }
}