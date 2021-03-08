using System;
using System.Collections.Generic;
using System.Text;
using Utilities.Models;

namespace WinSoftTest_DL.impl
{
    public class EmployeesDAO : IEmployeesDAO
    {
        public List<DepartmentDTO> GetAllDepartments()
        {
            List<DepartmentDTO> _depts = new List<DepartmentDTO>();
            try
            {
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return _depts;
        }

        public List<EmployeesDTO> GetDepartmentwiseEmployees(int DeptId)
        {
            List<EmployeesDTO> _employees = new List<EmployeesDTO>();
            try
            {

            }
            catch (Exception ex)
            {
                throw ex;
            }
            return _employees;
        }
    }
}
