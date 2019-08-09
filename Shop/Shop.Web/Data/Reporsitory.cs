using Shop.Web.Data.Entities;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Shop.Web.Data
{
    public class Reporsitory : IReporsitory
    {
        private readonly DataContext context;

        public Reporsitory(DataContext context)
        {
            this.context = context;
        }

        public IEnumerable<Product> GetProduct()
        {
            return this.context.Products.OrderBy(p => p);
        }

        public Product GetProduct(int id)
        {
            return this.context.Products.Find(id);
        }

        public void AddProduc(Product product)
        {
            this.context.Products.Add(product);
        }

        public void UpdateProduct(Product product)
        {
            this.context.Products.Update(product);
        }

        public void RemoveProduct(Product product)
        {
            this.context.Products.Remove(product);
        }

        public async Task<bool> SaveAllAsync()
        {
            return await this.context.SaveChangesAsync() > 0;
        }

        public bool ProductExists(int id)
        {
            return this.context.Products.Any(p => p.Id == id);
        }

    }
}
