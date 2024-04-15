namespace EmployeeData1.Models
{
    public class EmployeeMaster
    {
        public int EmployeeId { get; set; }
        public string? Name { get; set; }
        public string? Position { get; set; }
        public double Salary { get; set; }
        public DateTime JoinDate { get; set; }
    }
}