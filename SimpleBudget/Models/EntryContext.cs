using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SimpleBudget.Models
{
    public class EntryContext : DbContext
    {
        public EntryContext(DbContextOptions<EntryContext> options) : base(options){}

        public DbSet<Entry> Entries { get; set; }
    }
}
