using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.Persistence.Repositories;
using Project.DataAccess.Contexts;
using Project.DataAccess.Repositories.Abstracts;
using Project.Entity;

namespace Project.DataAccess.Repositories.Concretes
{
    public class ProductRepository: EfRepositoryBase<Product,BaseDbContext>, IProductRepository
    {
        public ProductRepository(BaseDbContext context) : base(context)
        {
        }
    }
}
