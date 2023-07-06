using ElevatorTransaction.Data;
using ElevatorTransaction.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace ElevatorTransaction.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class LiftConfigController : Controller
    {
        public readonly TransactionDbContext _liftconfig;
        public LiftConfigController(TransactionDbContext transactionDbContext)
        {
            _liftconfig = transactionDbContext;
            
        }

        [HttpGet]
        public async Task<IActionResult> GetAllDetails()
        {
            var LiftConfig = await _liftconfig.LiftConfiguration.ToListAsync();



            return Ok(LiftConfig);
        }

        [HttpPost]
        public async Task<IActionResult> AddDetails([FromBody] LiftConfiguration LiftConfigRequest)
        {
            await _liftconfig.LiftConfiguration.AddAsync(LiftConfigRequest);
            await _liftconfig.SaveChangesAsync();
            return Ok(LiftConfigRequest);
            
        }
    }
}
