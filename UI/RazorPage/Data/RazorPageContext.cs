using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Catalog.API.Entities;

namespace RazorPage.Data
{
    public class RazorPageContext : DbContext
    {
        public RazorPageContext (DbContextOptions<RazorPageContext> options)
            : base(options)
        {
        }

        public DbSet<Catalog.API.Entities.Product> Product { get; set; }
    }
}
