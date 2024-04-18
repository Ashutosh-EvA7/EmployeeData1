using EmployeeData1.Businesses;
using EmployeeData1.Models;
using Microsoft.AspNetCore.Mvc;

namespace EmployeeData1.Controllers
{
    public class EmployeeController(EmployeeBusiness employeeBusiness) : ControllerBase
    {
        private readonly EmployeeBusiness _employeeBusiness = employeeBusiness;

        [HttpGet("{id}")]
        public ActionResult<EmployeeMaster> GetEmployeeById(int id)
        {
            var result = _employeeBusiness.GetEmployeeById(id);
            if (result == null)
            {
                return NotFound();
            }
            return result;
        }
    }
}