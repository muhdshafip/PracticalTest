using System;
using System.Collections.Generic;
using System.Text;
using Utilities.Models;

namespace WinSoftTest_DL
{
    public interface IEmployeesDAO
    {
        List<DepartmentDTO> GetAllDepartments();
        List<EmployeesDTO> GetDepartmentwiseEmployees(int DeptId);
    }
}
