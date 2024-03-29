﻿using TeduShop.Data.Infrastructure;
using TeduShop.Model.Models;

namespace TeduShop.Data.Repositories
{
    public interface IProductRepository
    {

    }
    public class ProductRepository : RepositoryBase<Product>
    {
        public ProductRepository(DbFactory dbFactory) : base(dbFactory)
        {

        }
    }
}