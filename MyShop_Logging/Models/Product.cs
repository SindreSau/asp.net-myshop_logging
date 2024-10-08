namespace MyShop_Logging.Models;

public class Product : BaseEntity
{
    public int Id { get; set; }
    public string? Name { get; set; }
    public decimal Price { get; set; }
    public string? Description { get; set; }
    public string? ImageUrl { get; set; }
    public int CategoryId { get; set; }
    public virtual Category? Category { get; set; }
}