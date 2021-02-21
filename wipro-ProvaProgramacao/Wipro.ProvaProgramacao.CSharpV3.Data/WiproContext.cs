using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using Wipro.ProvaProgramacao.CSharpV3.Domain.Entities;

namespace Wipro.ProvaProgramacao.CSharpV3.Data
{
    public class WiproContext : DbContext
    {
        private static IConfiguration _configuration { get; set; }
        public WiproContext(DbContextOptions<WiproContext> options) : base(options)
        {
            
        }
        
        public WiproContext()
        {
        }

        public DbSet<Moedas> Moedas { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
           optionsBuilder.UseSqlServer("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=DbFilas;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
        }
    }
}
