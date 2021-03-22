using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using RazorPage_uppgift.Models;

namespace RazorPage_uppgift.Data
{
    public class RazorPage_uppgiftContext : DbContext
    {
        public RazorPage_uppgiftContext (DbContextOptions<RazorPage_uppgiftContext> options)
            : base(options)
        {
        }

        public DbSet<RazorPage_uppgift.Models.Event> Event { get; set; }
    }
}
