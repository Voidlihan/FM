using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace FarmersMarket.DataAccess
{
    public class FarmersMarketContext : DbContext
    {
        private readonly string connectionString;
        public FarmersMarketContext(string connectionString)
        {
            Database.Migrate();
            this.connectionString = connectionString;
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(connectionString);
        }
    }
}
