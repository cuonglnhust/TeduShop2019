﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TeduShop.Data.Infrastructure;
using TeduShop.Model.Models;

namespace TeduShop.Data.Repositories
{
    public interface IOrderRepository
    {

    }
    public class OrderReponsitory : RepositoryBase<Order>, IOrderRepository
    {
        public OrderReponsitory(DbFactory dbFactory): base(dbFactory)
        {

        }
    }
}
