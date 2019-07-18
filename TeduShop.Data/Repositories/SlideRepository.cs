using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TeduShop.Data.Infrastructure;
using TeduShop.Model.Models;

namespace TeduShop.Data.Repositories
{
    public interface ISildeRepository
    {

    }

    
    public class SildeRepository : RepositoryBase<Slide>, ISildeRepository
{
        public SildeRepository(DbFactory dbFactory) : base(dbFactory)
        {

        }
    }
}
