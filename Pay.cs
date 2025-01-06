namespace HR3.Models
{
    public class Pay
    {
        public int Id { get; set; }
        public String Name { get; set; }
        public TimeOnly HoursWorked { get; set; }
        public TimeOnly extraHours { get; set; }
        public int pay  { get; set; }
        public int earns { get; set; }
    }
}
