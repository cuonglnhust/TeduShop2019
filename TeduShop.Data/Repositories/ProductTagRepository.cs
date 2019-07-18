using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TeduShop.Data.Infrastructure;
using TeduShop.Model.Models;

namespace TeduShop.Data.Repositories
{
    public interface IProductTagRepository
    {

    }
    public class ProductTagRepository : RepositoryBase<ProductTag>, IPostTagRepository
    {
        public ProductTagRepository(DbFactory dbFactory) : base(dbFactory)
        {

        }
    }
}
