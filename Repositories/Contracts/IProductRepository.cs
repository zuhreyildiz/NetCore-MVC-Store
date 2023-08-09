using Entities.Models;

namespace Repositories.Contracts
{
    public interface IProductRepository : IRepositoryBase<Product>
    {
        object Products { get; set; }

        IQueryable<Product> GetAllProducts(bool trackChanges);
        IEnumerable<Product> GetAllProducts(object trackChanges);
        Product? GetOneProduct(int id, bool trackChanges);
        //IQueryable<Product> GetShowcaseProducts(bool trackChanges);
        //void CreateOneProduct(Product product);
        //void DeleteOneProduct(Product product);
        //void UpdateOneProduct(Product entity);
    }
}