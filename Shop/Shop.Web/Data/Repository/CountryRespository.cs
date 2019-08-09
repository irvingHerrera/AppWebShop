using Shop.Web.Data.Contract;
using Shop.Web.Data.Entities;

namespace Shop.Web.Data.Repository
{
    public class CountryRespository : GenericRepository<Country>, ICountryRepository
    {
        public CountryRespository(DataContext context) : base(context)
        {
        }
    }
}
