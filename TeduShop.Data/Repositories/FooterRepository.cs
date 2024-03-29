﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TeduShop.Data.Infrastructure;
using TeduShop.Model.Models;

namespace TeduShop.Data.Repositories
{
    public interface IFooterRepository
    {

    }
    public class FooterRepository : RepositoryBase<Footer>  , IFooterRepository
    {
        public FooterRepository(DbFactory dbFactory) : base(dbFactory)
        {

        }
    }
}
