namespace ElevatorTransaction.Models
{
    public class Transaction
    {
        public int Id { get; set; }
        public int CurrentFloor { get; set; }
        public int DestinationFloor { get; set;}
        public int PersonCount { get; set; }
        public double PersonWeight { get; set; }
        public DateTime DateTime { get; set; } = DateTime.Now;

    }
}
