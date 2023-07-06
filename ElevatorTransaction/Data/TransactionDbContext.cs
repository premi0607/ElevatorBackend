using ElevatorTransaction.Models;
using ElevatorTransaction.Models.Converter;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Hosting;

namespace ElevatorTransaction.Data
{
    public class TransactionDbContext : DbContext
    {
        public TransactionDbContext(DbContextOptions options) : base(options)
        {
        }
        public DbSet<Transaction> Transactions { get; set; }
        public DbSet<LiftConfiguration> LiftConfiguration { get; set; }
    }

}
