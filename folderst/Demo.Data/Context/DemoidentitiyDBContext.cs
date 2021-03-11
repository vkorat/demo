using Demo.Dmain.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.Data.Context
{
    public class DemoidentitiyDBContext : DbContext
    {
        public DemoidentitiyDBContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<Course> Course { get; set; }
    }
}
