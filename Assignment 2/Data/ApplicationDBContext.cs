using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Assignment_2.Models;
using Microsoft.EntityFrameworkCore;

namespace Assignment_2.Data
{
    public class ApplicationDBContext:DbContext
    {

        public ApplicationDBContext(DbContextOptions<ApplicationDBContext> options) : base(options)
        {

        }

        public DbSet<Fighters> Fighters { get; set; }

    }
}
