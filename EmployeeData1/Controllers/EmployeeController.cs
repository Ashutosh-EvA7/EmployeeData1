using EmployeeData1.Businesses;
using EmployeeData1.Models;
using Microsoft.AspNetCore.Mvc;

namespace EmployeeData1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeController(EmployeeBusiness employeeBusiness) : ControllerBase
    {
        private readonly EmployeeBusiness _employeeBusiness = employeeBusiness;

        [HttpGet]
        public IEnumerable<EmployeeMaster> Getemployee()
        {
            var res = _employeeBusiness.GetEmployee();
            return res;
        }
        [HttpGet("{id}")]
        public ActionResult<EmployeeMaster> GetEmployeeById(int id)
        {
            var result= _employeeBusiness.GetEmployeeById(id);
            if (result==null)
            {
                return NotFound();
            }
            return result;
        }
    }
}
