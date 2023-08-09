using Entities.Models;
using Repositories.Contracts;

namespace Repositories
{
    public class ProductRepository : RepositoryBase<Product>, IProductRepository
    {
        public ProductRepository(RepositoryContext context) : base(context)
        {
        }

        public object Products { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public IQueryable<Product> GetAllProducts(bool trackChanges) => FindAll(trackChanges);

        public IEnumerable<Product> GetAllProducts(object trackChanges)
        {
            throw new NotImplementedException();
        }

        public Product? GetOneProduct(int id, bool trackChanges)
        {
            return FindByCondition(p => p.ProductId.Equals(id),trackChanges);
        }
        
    }
}
    