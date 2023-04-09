using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.Persistence.Repositories;
using Project.Entity;

namespace Project.DataAccess.Repositories.Abstracts
{
    public interface IProductRepository : IRepository<Product>, IAsyncRepository<Product>
    {

    }
}
