using Shop.Web.Data.Contract;
using Shop.Web.Data.Entities;

namespace Shop.Web.Data.Repository
{
    public class ProductRepository : GenericRepository<Product>, IProductRepository
    {
        public ProductRepository(DataContext context) : base(context)
        {
        }
    }
}
