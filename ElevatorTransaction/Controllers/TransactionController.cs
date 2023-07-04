using ElevatorTransaction.Data;
using ElevatorTransaction.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace ElevatorTransaction.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class TransactionController : Controller
    {
        private readonly TransactionDbContext _context;
        public TransactionController(TransactionDbContext transactionDbContext)
        {
            _context = transactionDbContext;
            
        }
        [HttpGet]
        public async Task<IActionResult> GetAllTransactions()
        {
            var transactions = await _context.Transactions.ToListAsync();
            return Ok(transactions);
        }


        [HttpPost]
        public async Task<IActionResult> AddTransaction([FromBody] Transaction transactionRequest)
        {
            await _context.Transactions.AddAsync(transactionRequest);
            await _context.SaveChangesAsync();

            return Ok(transactionRequest);

        }
    }
}
