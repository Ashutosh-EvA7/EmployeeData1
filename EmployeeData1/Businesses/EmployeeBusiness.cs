using EmployeeData1.Models;

namespace EmployeeData1.Businesses
{
    public class EmployeeBusiness
    {
        private readonly List<EmployeeMaster> _employees =
    [
        new EmployeeMaster { EmployeeId = 1, Name = "John Doe", Position = "Software Engineer", Salary = 5000, JoinDate = new DateTime(2020, 01, 01) },
        new EmployeeMaster { EmployeeId = 2, Name = "Jane Doe", Position = "Senior Software Engineer", Salary = 6000, JoinDate = new DateTime(2019, 06, 15) },
        new EmployeeMaster { EmployeeId = 3, Name = "Bob Smith", Position = "Software Engineer", Salary = 5500, JoinDate = new DateTime(2021, 03, 20) },
        new EmployeeMaster { EmployeeId = 4, Name = "Alice Johnson", Position = "Senior Software Engineer", Salary = 6500, JoinDate = new DateTime(2018, 09, 10) },
        new EmployeeMaster { EmployeeId = 5, Name = "Charlie Brown", Position = "Software Engineer", Salary = 5250, JoinDate = new DateTime(2022, 02, 01) }
    ];
        public List<EmployeeMaster> GetEmployee()
        {
            var result = _employees;
            return result;
        }

        public EmployeeMaster? GetEmployeeById(int id)
        {
            return _employees.FirstOrDefault(e => e.EmployeeId == id);
        }
    }
}