using Microsoft.EntityFrameworkCore;
using Shop.Web.Data.Contract;
using Shop.Web.Data.Entities;
using System.Linq;

namespace Shop.Web.Data.Repository
{
    public class ProductRepository : GenericRepository<Product>, IProductRepository
    {
        private readonly DataContext context;

        public ProductRepository(DataContext context) : base(context)
        {
            this.context = context;
        }

        public IQueryable<Product> GetAllWithUsers()
        {
            return this.context.Products.Include(p => p.User);
        }
    }
}
