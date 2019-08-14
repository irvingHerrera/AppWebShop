using Shop.Web.Data.Entities;
using System.Linq;

namespace Shop.Web.Data.Contract
{
    public interface IProductRepository : IGenericRepository<Product>
    {
        IQueryable<Product> GetAllWithUsers();
    }
}
