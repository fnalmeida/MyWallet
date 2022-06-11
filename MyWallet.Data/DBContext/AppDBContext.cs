using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using MyWallet.Domain;
using MyWallet.Domain.Entities;

namespace Data.DBContext
{
    public class AppDBContext : DbContext
    {
        public DbSet<Lancamento> Lancamentos { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
          => options.UseSqlite("DataSource=MyWallet.db;Cache=Shared");

    }


}
