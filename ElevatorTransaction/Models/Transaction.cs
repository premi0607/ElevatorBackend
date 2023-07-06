using Microsoft.EntityFrameworkCore;

namespace ElevatorTransaction.Models
{
    
    public class Transaction
    {
        public int Id { get; set; }
        public int CurrentFloor { get; set; }
        public int DestinationFloor { get; set; }
        public int PersonCount { get; set; }
        public double PersonWeight { get; set; }
        //public DateTime DateTime { get; set; } = DateTime.Now;

        //public DateOnly DateOnly { get; set; } = DateOnly.FromDateTime(DateTime.Now);
        //public TimeOnly TimeOnly { get; set; } = TimeOnly.FromDateTime(DateTime.Now);

        public string? TransactionDateOnly { get; set; } = DateTime.Now.ToString();

        public string? TransactionTimeOnly { get; set; } = DateTime.Now.ToString();

        //public DateOnly DateOnlyValue { get; internal set; }
        //public TimeOnly TimeOnlyValue { get; internal set; }
      
    }
}
