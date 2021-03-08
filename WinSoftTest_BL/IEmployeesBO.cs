using System;
using System.Collections.Generic;
using System.Text;
using Utilities.Models;

namespace WinSoftTest_BL
{
    public interface IEmployeesBO
    {
        List<DepartmentDTO> GetAllDepartments();
        List<EmployeesDTO> GetDepartmentwiseEmployees(int DeptId);
    }
}
