using Shop.Web.Data.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Shop.Web.Data
{
    public interface IReporsitory
    {
        void AddProduc(Product product);
        IEnumerable<Product> GetProduct();
        Product GetProduct(int id);
        bool ProductExists(int id);
        void RemoveProduct(Product product);
        Task<bool> SaveAllAsync();
        void UpdateProduct(Product product);
    }
}