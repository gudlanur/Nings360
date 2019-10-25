using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.SqlServer;

namespace NingsMart.Models
{
    public class ProductContext : DbContext
    {

        public ProductContext()
        {

        }
        public ProductContext(DbContextOptions optons) :base(optons)
        {

        }

       public DbSet<ProductViewModel> productTble { get; set; }
    }
}
