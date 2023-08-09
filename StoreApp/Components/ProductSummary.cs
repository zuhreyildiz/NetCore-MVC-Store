using Microsoft.AspNetCore.Mvc;
using Repositories;

namespace StoreApp.Compunents
{
    public class ProductSummary : ViewComponent
    {
        private readonly RepositoryContext _context;
        public ProductSummary (RepositoryContext context)
        {
            _context = context;
        }
        public string  Invoke()
        {
            return _context.Products.Count().ToString();
        }
    }
}