using ElevatorTransaction.Models;
using Microsoft.EntityFrameworkCore;

namespace ElevatorTransaction.Data
{
    public class TransactionDbContext : DbContext
    {
        public TransactionDbContext(DbContextOptions options) : base(options)
        {
        }
        public DbSet<Transaction> Transactions { get; set; }
    }
}
