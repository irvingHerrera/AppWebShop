using Microsoft.EntityFrameworkCore;
using Shop.Web.Data.Contract;
using System.Linq;
using System.Threading.Tasks;

namespace Shop.Web.Data.Repository
{
    public class GenericRepository<T> : IGenericRepository<T> where T : class, IEntity
    {
        private readonly DataContext context;

        public GenericRepository(DataContext context)
        {
            this.context = context;
        }

        public async Task<bool> CreateAsync(T entity)
        {
            await this.context.Set<T>().AddAsync(entity);
            return await this.context.SaveChangesAsync() > 0;
        }

        public async Task<bool> DeteleAsync(T entity)
        {
            this.context.Set<T>().Remove(entity);
            return await this.context.SaveChangesAsync() > 0;
        }

        public async Task<bool> ExisAsync(int id)
        {
            return await this.context.Set<T>().AnyAsync(e => e.Id == id);
        }

        public IQueryable<T> Getall()
        {
            return this.context.Set<T>().AsNoTracking();
        }

        public async Task<T> GetByIdAsync(int id)
        {
            return await this.context.Set<T>()
                .AsNoTracking()
                .FirstOrDefaultAsync(e => e.Id == id);
        }

        public async Task<bool> UpdateAsync(T entity)
        {
            this.context.Set<T>().Remove(entity);
            return await this.context.SaveChangesAsync() > 0;
        }
    }
}
