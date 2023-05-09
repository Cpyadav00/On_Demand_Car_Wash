namespace On_Demand_Car_Wash.Model
{
    public class Admin
    {
        public int AdminId { get; set; }
        public string AdminName { get; set; }
        public string AdminEmail { get; set; } = null!;
        public string AdminPassword { get; set; } = null!;
    }
}
