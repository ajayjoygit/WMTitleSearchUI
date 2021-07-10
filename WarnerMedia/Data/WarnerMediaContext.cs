using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WarnerMedia.Data.Entities;

namespace WarnerMedia.Data
{
   
    public class WarnerMediaContext:DbContext
    {
        private readonly IConfiguration _config;
        public WarnerMediaContext(IConfiguration config)
        {
            _config = config;
        }
        public DbSet<Title> Titles { get; set; }
        public DbSet<Genre> Genres { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlServer(_config["ConnectionStrings:DutchContextDb"]);
        }
    }

    
}
