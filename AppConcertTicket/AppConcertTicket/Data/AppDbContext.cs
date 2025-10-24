using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AppConcertTicket.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace AppConcertTicket.Data
{
    class AppDbContext : DbContext
    {
        public DbSet<Account> Accounts { get; set; }
        public DbSet<Concert> Concerts { get; set; }
        public DbSet<Ticket> Tickets { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            // Load configuration directly as per your example
            string connectionString = AppSettings.GetConnectionString("Default");
            optionsBuilder.UseNpgsql(connectionString);                           // Builds the configuration

        }
    }
}
