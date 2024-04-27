using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using NDSDotNetCore.ConsoleApp.Dtos;
using NDSDotNetCore.ConsoleApp.Services;

namespace NDSDotNetCore.ConsoleApp.EFCoreExamples
{
    internal class AppDbContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(ConnectionStrings.sqlConnectionStringBuilder.ConnectionString);
        }

        public DbSet<BlogDto> Blogs { get; set; }
    }
}
