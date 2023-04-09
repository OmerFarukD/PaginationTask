using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Project.Entity;

namespace Project.DataAccess.Contexts
{
    public class BaseDbContext : DbContext
    {
        public BaseDbContext(DbContextOptions<BaseDbContext> options): base(options)
        {
            
        }

        public DbSet<Product> Products { get; set; }
    }
}
