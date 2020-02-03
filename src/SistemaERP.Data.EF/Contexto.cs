using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using SistemaERP.Core.Entidades;
using SistemaERP.Core.Interfaces.Repositorios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaERP.Data
{
    public class Contexto : DbContext, IContexto
    {
        public DbSet<Venda> Venda { get; set; }
        public DbSet<VendaItem> VendaItem { get; set; }
        public static readonly ILoggerFactory MyLoggerFactory
            = LoggerFactory.Create(builder => { builder.SetMinimumLevel(LogLevel.Debug); });
        private static string _connectionString;
        public void Migrate() => Database.Migrate();
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    => optionsBuilder
        .UseMySQL(_connectionString ?? "Server=localhost;User Id=root;Password=123;Database=sistemaerp")
        .UseLoggerFactory(MyLoggerFactory)
        .EnableSensitiveDataLogging();

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.ApplyConfiguration(new VendaMap());
        }
        public void SetarConnectionString(string conn)
        {
            _connectionString = conn;
        }
    }
}
