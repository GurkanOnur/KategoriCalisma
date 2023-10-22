using KategoriCalisma.Models.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KategoriCalisma.Infrastructure.Context
{
    public class AppDbContext:DbContext
    {
        public DbSet<Kategori> Kategoriler { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server= (localDb)\\MSSQLLocalDb; Database=KategoriDb;Trusted_Connection=true;");
        }
    }
}
