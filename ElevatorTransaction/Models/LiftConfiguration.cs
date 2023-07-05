namespace ElevatorTransaction.Models
{
    public class LiftConfiguration
    {
        public int Id { get; set; }
        public string? LiftBrand { get; set; }
        public int LiftMaxSpeed { get; set; }
        public int LiftCapacity { get; set; }
        public int MaxWeight { get; set; }
        public string? BatteryType { get; set; }
        public int BatteryLevel { get; set; }
        public int BatteryCapacity { get; set; }
        public int PowerConsumed { get; set; }  
        public int DoorOpenCloseSpeed { get; set; }
    }
}
