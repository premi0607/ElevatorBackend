using ElevatorTransaction.Data;
using ElevatorTransaction.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Collections.Immutable;

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
            // Calculate which page user wants to go
            // 1.User may click Next or previous
            // 2. User may type specific page , maintain (current page)

            // 3. from the paginatedResult obtain the specific page you would like to return

            // Pagination
            // LINQ to select top 2 rows from the table
            //var result = from m in transactions.Take(2) select m;

            // Skipping X Rows and Taking Y rows for selection
            //var paginatedResult = (from m in transactions select m).Skip(2).Take(1);


            //var foo = (From t In transacation Select Transaction).Skip(30).Take(30);


            //var groupByQuery = _context.Transactions.GroupBy(p => p.DestinationFloor);

            //var res = from g in groupByQuery select new {id = g.Key, count = g.ToList().Count()};

            //var results = from p in _context.Transactions
            //            group p.DestinationFloor by p.Id into g
            //          select new { PersonId = g.Key, Cars = g.ToList()};

            return Ok(transactions);
        }

        [Route("group")]
        [HttpGet]
        public IActionResult GroupbyDate()
        {
            var groupByQuery = _context.Transactions.GroupBy(p => p.TransactionDateOnly);

            var res = from g in groupByQuery select new { Date = g.Key, NumberOfTransaction = g.ToList().Count() };
            return Ok(res);

        }

        [HttpPost]
        public async Task<IActionResult> AddTransaction([FromBody] Transaction transactionRequest)
        {
            transactionRequest.TransactionDateOnly = DateTime.Now.ToShortDateString();
            transactionRequest.TransactionTimeOnly = DateTime.Now.ToShortTimeString();

            //transactionRequest.DateOnlyValue = DateOnly.FromDateTime(DateTime.Now);
            //transactionRequest.TimeOnlyValue = TimeOnly.FromDateTime(DateTime.Now);

            await _context.Transactions.AddAsync(transactionRequest);
            await _context.SaveChangesAsync();

            return Ok(transactionRequest);

        }
    }
}
