using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GolfApp.Entities
{
    public class GolfDBContext : DbContext
    {
        public GolfDBContext (DbContextOptions<GolfDBContext> options) : base(options)
        {
       
        }

        public DbSet<Course> Courses { get; set; }
    }
}
