using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using MiniProjecT.Models;

namespace MiniProjecT.Data
{
    public class MiniProjecTContext : DbContext
    {
        public MiniProjecTContext (DbContextOptions<MiniProjecTContext> options)
            : base(options)
        {
        }

        public DbSet<MiniProjecT.Models.Product> Product { get; set; }
    }
}
