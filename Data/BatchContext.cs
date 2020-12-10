using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using Microsoft.EntityFrameworkCore;
using Lab_5___Hootch.Models;

namespace Lab_5___Hootch.Data
{
    public class BatchContext : DbContext
    {
        public BatchContext (DbContextOptions<BatchContext> options)
            : base (options)
        {
        }
        public DbSet<Batch> Batch { get; set; }
    }
}
