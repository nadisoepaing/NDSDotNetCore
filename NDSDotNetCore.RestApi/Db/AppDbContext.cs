using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using NDSDotNetCore.RestApi.Db;

namespace NDSDotNetCore.RestApi.Db
{
    internal class AppDbContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(ConnectionStrings.sqlConnectionStringBuilder.ConnectionString);
        }

        public DbSet<Model.BlogModel> Blogs { get; set; }
    }
}
