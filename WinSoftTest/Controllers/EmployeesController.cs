using Microsoft.AspNetCore.Mvc;
using System;
using WinSoftTest_BL;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace WinSoftTest.Controllers
{
    [Route("api/[controller]")]
    public class EmployeesController : Controller
    {
        private IEmployeesBO _employeesBO;

        public EmployeesController(IEmployeesBO _employeesBO)
        {
            this._employeesBO = _employeesBO;
        }

        [HttpGet("getalldepartments")]
        public IActionResult GetAllDepartments()
        {
            try
            {
                return Ok(_employeesBO.GetAllDepartments());
            }
            catch (Exception ex)
            {
                return BadRequest(new
                {
                    data = ex.ToString(),
                    msgType = "danger"
                });
            }
        }

        [HttpGet("getdepartmentwiseemployees/{deptid}")]
        public IActionResult GetDepartmentwiseEmployees(int DeptId)
        {
            try
            {
                return Ok(_employeesBO.GetDepartmentwiseEmployees(DeptId));
            }
            catch (Exception ex)
            {
                return BadRequest(new
                {
                    data = ex.ToString(),
                    msgType = "danger"
                });
            }
        }
    }
}
