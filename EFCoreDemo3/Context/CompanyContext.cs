using EFCoreDemo3.Models;
using Microsoft.EntityFrameworkCore;

namespace EFCoreDemo3.Context
{
    public class CompanyContext:DbContext
    {
        public CompanyContext(DbContextOptions<CompanyContext> options) : base(options)
        { }

        public DbSet<Dept> Dept { get; set; }
        public DbSet<Emp> Emps { get; set; }

        public DbSet<Area> Areas { set; get; }
 
    }
}
