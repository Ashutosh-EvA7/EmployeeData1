using EmployeeData1.Models;

namespace EmployeeData1.Businesses
{
    public class EmployeeBusiness
    {
        private readonly List<EmployeeMaster> _employees =
    [
        new EmployeeMaster { EmployeeId = 1, Name = "Manas", Position = "Engineer", Salary = 50000, JoinDate = new DateTime(2023, 01, 01) },
        new EmployeeMaster { EmployeeId = 2, Name = "Prajyot", Position = "Senior Engineer", Salary = 60000, JoinDate = new DateTime(2013, 06, 15) },
        new EmployeeMaster { EmployeeId = 3, Name = "RAjat", Position = "Software Engineer", Salary = 55000, JoinDate = new DateTime(2023, 03, 20) },
        new EmployeeMaster { EmployeeId = 4, Name = "Saloni", Position = "Senior Software Developer", Salary = 65000, JoinDate = new DateTime(2013, 09, 10) },
        new EmployeeMaster { EmployeeId = 5, Name = "Rakesh", Position = "Software Engineer", Salary = 52500, JoinDate = new DateTime(2023, 02, 01) }
    ];

        public EmployeeMaster? GetEmployeeById(int id)
        {
            return _employees.FirstOrDefault(e => e.EmployeeId == id);
        }
    }
}