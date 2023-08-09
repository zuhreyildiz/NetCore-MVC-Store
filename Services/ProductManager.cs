using Entities.Models;
using Repositories.Contracts;
using Services.Contracts;

namespace Services;

public class ProductManager : IProductService
{
    private readonly IProductRepository _manager;
    private bool trackChanges;

    public ProductManager(IProductRepository manager)
    {
        _manager = manager;
    }

    public IEnumerable<Product> GetAllProducts(bool treckChanges)
    {
        return _manager.GetAllProducts(trackChanges);
    }

    public Product? GetOneProduct(int id, bool treckChanges)
    {
        var product = _manager.GetOneProduct(id, treckChanges);
        if(product is null)
        throw new Exception("Product no fould!");
        return product;
    }
}
