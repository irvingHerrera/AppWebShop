using System.Linq;
using System.Threading.Tasks;

namespace Shop.Web.Data.Contract
{
    public interface IGenericRepository<T> where T : class
    {
        IQueryable<T> Getall();
        Task<T> GetByIdAsync(int id);
        Task<bool> CreateAsync(T entity);
        Task<bool> UpdateAsync(T entity);
        Task<bool> DeteleAsync(T entity);
        Task<bool> ExisAsync(int id);
    }
}
